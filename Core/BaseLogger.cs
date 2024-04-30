using Serilog;
using System;
using System.IO;

namespace Core
{
    public static class BaseLogger
    {
        private static string _directoryPath = $"D:\\QALightsLessons\\Lesson1\\SeleniumLesson\\Logs\\";
        private static string _fileName;
        private static string _fullFilePath;

        public static void Initialize()
        {
            CreateLogDirectory();
            CreateFile();
            StartUpLogging();
        }

        private static void CreateLogDirectory()
        {
            Directory.CreateDirectory(_directoryPath);
        }

        private static void CreateFile()
        {
            var random = new Random().Next(0, 99);
            _fileName = $"Test_{random}-{DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss")}.txt";
            _fullFilePath = Path.Combine(_directoryPath, _fileName);
            File.Create(_fullFilePath).Close();
        }

        private static void StartUpLogging()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(_fullFilePath).CreateLogger();
        }

        public static void Info(string message)
        {
            Log.Information(message);
        }

        public static void Error(string message)
        {
            Log.Error(message);
        }
    }
}
