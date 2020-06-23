using System;
using static System.Console;

namespace DataProcessor
{
    internal class FileProcessor
    {
        public string InputFilePath { get; }

        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        internal void Process()
        {
            WriteLine($"Begin process of {InputFilePath}");
        }
    }
}