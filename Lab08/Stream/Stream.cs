using System;
using System.IO;
using System.IO.Compression;

namespace Stream
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input path to file:");
            string searchPath = Console.ReadLine();

            Console.WriteLine("Input file name with extension:");
            string searchFileName = Console.ReadLine();

            string[] foundFiles = Directory.GetFiles(searchPath, searchFileName, SearchOption.AllDirectories);

            if (foundFiles.Length == 0)
            {
                Console.WriteLine("File not found");
                return;
            }

            Console.WriteLine($"Found {foundFiles.Length} file(s)");
            Console.WriteLine("Do you want to compress file (Y/N)");
            string compressOption = Console.ReadLine();

            if (compressOption.ToLower() == "y")
            {
                foreach (string filePath in foundFiles)
                {
                    CompressFile(filePath);
                }
            }
            else
            {
                foreach (string filePath in foundFiles)
                {
                    Console.WriteLine($"File content {filePath}:");
                    PrintFileContent(filePath);
                }
            }
            Console.ReadLine();
        }

        static void PrintFileContent(string filePath)
        {
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fs))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        static void CompressFile(string filePath)
        {
            string compressedFilePath = filePath + ".gz";
            using (FileStream sourceFile = File.OpenRead(filePath))
            {
                using (FileStream compressedFile = File.Create(compressedFilePath))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFile, CompressionMode.Compress))
                    {
                        sourceFile.CopyTo(compressionStream);
                    }
                }
            }

            Console.WriteLine($"File {Path.GetFileName(filePath)} was compressed to {compressedFilePath}.");
        }

    }
}