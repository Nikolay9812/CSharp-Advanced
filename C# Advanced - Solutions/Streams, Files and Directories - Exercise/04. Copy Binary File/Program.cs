﻿using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "../../../copyMe.png";
            string destinationFile = "../../../copiedFile.png";

            int bufferSize = 1024;
            var buffer = new byte[bufferSize];
            int bytesRead = -1;

            using var fileReader = new FileStream(sourceFile, FileMode.Open);
            using var fileWriter = new FileStream(destinationFile, FileMode.Create);

            while ((bytesRead = fileReader.Read(buffer, 0, bufferSize)) > 0)
            {
                fileWriter.Write(buffer, 0, bytesRead);
            }
        }
    }
}
