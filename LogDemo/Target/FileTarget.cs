using LogDemo.Event;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LogDemo.Target
{
    public class FileTarget : ILogTarget
    {
        private string _filePath;

        public FileTarget(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteLog(LogData logData)
        {
            using var fs = new FileStream(_filePath, FileMode.Append);
            using var sw = new StreamWriter(fs);
            sw.WriteLine(logData);
        }
    }
}
