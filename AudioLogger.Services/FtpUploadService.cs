﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using log4net;

namespace AudioLogger.Services
{
    public class FtpUploadService : IUploadService
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof (FtpUploadService));
        private WebClient _client;
        private readonly string _host;
        private readonly string _password;
        private readonly string _targetDirectory;
        private readonly string _username;
        private readonly string _format;

        public FtpUploadService(Parameters parameters)
        {
            _host = parameters.FtpHost;
            _targetDirectory = parameters.FtpTargetDirectory;
            _username = parameters.FtpUsername;
            _password = parameters.FtpPassword;
            _format = parameters.FileNameFromDateFormat;
        }

        public bool TryUploadFile(AudioLog audioLog)
        {
            _client = new WebClient
            {
                Credentials = new NetworkCredential(_username, _password),
                Proxy = null
            };
            try
            {
                var address = $"ftp://{_host}/{_targetDirectory}/{Path.GetFileName(audioLog.GetMp3())}";
                _client.UploadFile(address,
                    "STOR", audioLog.GetMp3());
            }
            catch (Exception exception)
            {
                Logger.Warn(exception.Message);
                return false;
            }
            return true;
        }

        public IEnumerable<AudioLog> GetFilesOlderThan(DateTime date)
        {
            var webRequest = WebRequest.Create($"ftp://{_host}/{_targetDirectory}") as FtpWebRequest;
            if (webRequest == null) throw new WebException("Failed to create a web request");
            webRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            webRequest.Credentials = new NetworkCredential(_username, _password);

            var webResponse = webRequest.GetResponse() as FtpWebResponse;
            if (webResponse != null)
            {
                using (var stream = webResponse.GetResponseStream())
                {
                    if (stream != null)
                    {
                        using (var streamReader = new StreamReader(stream))
                        {
                            string line;
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                var fullFileName = line.Split('/').Last();
                                var file = fullFileName.Split('.').First();

                                DateTime fileTime;
                                if (!DateTime.TryParseExact(file, _format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out fileTime))
                                {
                                    Logger.Warn($"Malformed file name {file}");
                                    continue;
                                }
                                if (fileTime.CompareTo(date) < 0)
                                {
                                    yield return AudioLog.FromPath(line);
                                }
                            }
                        }
                    }
                    else throw new WebException("Failed to get the response stream of directory listing");
                }
            }
            else throw new WebException("Failed to get a response of directory listing");
        }

        public bool TestConnection()
        {
            try
            {
                var address = $"ftp://{_host}/{_targetDirectory}";
                var request = WebRequest.Create(address) as FtpWebRequest;
                if (request == null) throw new WebException("Failed to create a web request");

                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Timeout = 200;
                request.Credentials = new NetworkCredential(_username, _password);
                request.ReadWriteTimeout = 200;
                var response = request.GetResponse();
                response.GetResponseStream();

                return response.GetResponseStream() != Stream.Null;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
        }

        public bool TryRemoveFiles(IEnumerable<AudioLog> files)
        {
            try
            {
                foreach (var file in files)
                {

                    var deleteRequest = WebRequest.Create($"ftp://{_host}/{file.GetMp3()}") as FtpWebRequest;
                    if (deleteRequest == null) throw new WebException("Failed to create a web request");
                    deleteRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                    deleteRequest.Credentials = new NetworkCredential(_username, _password);
                    deleteRequest.GetResponse();
                }
            }
            catch (Exception ex)
            {
                Logger.Warn("Failed to delete files");
                Logger.Warn(ex.Message);
                return false;
            }
            return true;
        }
    }
}