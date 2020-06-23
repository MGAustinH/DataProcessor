using System;
using static System.Console;
using System.IO;

namespace DataProcessor
{
    internal class FileProcessor
    {
        private static readonly string BackupDirectoryName = "backup";
        private static readonly string InProgressDirectoryName = "processing";
        private static readonly string CompletedDirectoryName = "complete";
        public string InputFilePath { get; }

        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        internal void Process()
        {
            WriteLine($"Begin process of {InputFilePath}");

            if (!File.Exists(InputFilePath)) 
            {
                WriteLine($"Error: file {InputFilePath} does not exist");
                return;
            }

            string rootDirectoryPath = new DirectoryInfo(InputFilePath).Parent.Parent.FullName;
            WriteLine($"Root data path is {rootDirectoryPath}");


            string inputFileDirectoryPath = Path.GetDirectoryName(InputFilePath);
            string backupDirectoryPath = Path.Combine(rootDirectoryPath, BackupDirectoryName);

            Directory.CreateDirectory(backupDirectoryPath);

            string inputFileName = Path.GetFileName(InputFilePath);
            string backupFilePath = Path.Combine(backupDirectoryPath, inputFileName);

            WriteLine($"Coptying {InputFilePath} to {backupFilePath}");
            File.Copy(InputFilePath, backupFilePath, true);

        }
    }
}