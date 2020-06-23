using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            var command = args[0];

            if (command == "--file")
            {
                var filePath = args[1];
                WriteLine($"Single file {filePath} selected");
                ProcessingSingleFile(filePath);
            }
            else if (command == "--dir")
            {
                var directoryPath = args[1];
                var fileType = args[2];
                WriteLine($"Directory {directoryPath} selected for {fileType} files");
                ProcessDirectory(directoryPath, fileType);
            }
            else 
            {
                WriteLine("Invalid command line options");
            }

            WriteLine("press enter to quit");
            ReadLine();
        }

        static void ProcessingSingleFile(string filePath) 
        {
            var fileProcessor = new FileProcessor(filePath);
            fileProcessor.Process();
        }
        static void ProcessDirectory(string directoryPath, string filePath) 
        {
            throw new Exception("unimplemented method");
        }
    }

}
