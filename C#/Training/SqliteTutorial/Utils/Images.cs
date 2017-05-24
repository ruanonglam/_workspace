using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace SqliteTutorial.Utils
{
    class Images
    {
        private static byte[] GetBytesFromFile(string filename)
        {
            try
            {
                String fullFilePath = Common.Constants.IMG_URL + filename;
                return File.ReadAllBytes(fullFilePath);
            }
            catch (Exception e)
            {
                // Log
                throw e;
            }
            finally
            {
                // Ghi log
            }

        }

        public static Bitmap ByteToImage(String filename)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = GetBytesFromFile(filename);
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
