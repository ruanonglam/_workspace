using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EncryptAndDecryptData.Classes
{
    class LogicMainForm
    {

        public String AutoCreateOutputFolder(String inputFile, String outputFolder, String extend)
        {
            string[] tokens = inputFile.Split('\\');
            string filename = tokens[tokens.Length - 1];

            string folder = inputFile.Replace(filename, outputFolder);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            return inputFile.Replace(filename, outputFolder + replaceExtendtion(filename, extend));
        }

        public String AutoCreateOutputFolder(String inputFolder, String outputFolder)
        {
            string folder = inputFolder + outputFolder;
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            return folder;
        }

        public String GetOutputFileFromInputFile(String inputFile, String outputFolder)
        {
            string[] tokens = inputFile.Split('\\');
            string filename = tokens[tokens.Length - 1];

            return outputFolder + filename;
        }

        private String replaceExtendtion(String filename, String extend)
        {
            string[] tokens = filename.Split('.');
            if (tokens.Length == 2)
                return tokens[0] + "." + extend;
            else
                return filename;
        }

    }
}
