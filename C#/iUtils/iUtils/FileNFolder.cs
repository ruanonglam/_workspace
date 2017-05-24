using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace iUtils
{
    public class FileNFolder
    {

        public FileNFolder() { }

        /// <summary>
        /// Get tên file từ đường dẫn được chỉnh định
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public String copyFileNameFromPath(String path)
        {
            try 
            {
                String[] tokens = path.Split('\\', '/');
                String fileName = tokens[tokens.Length - 1];
                if (fileName.Contains("."))
                    return fileName;
            }
            catch(NullReferenceException nre)
            {
                throw nre;
            }
            catch(ArgumentException ae)
            {
                throw ae;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void copyFile(String from, String to)
        {
            try
            {
                // Tạo folder đích[from], trường hợp folder đã tồn tại thì không tạo
                new FileInfo(to).Directory.Create();

                // Copy file
                File.Copy(from, to);
            }
            catch (IOException ioe)
            {
                throw ioe;
            }
            catch (UnauthorizedAccessException uae)
            {
                throw uae;
            }
            catch (ArgumentException ae)
            {
                throw ae;
            }
            catch (NotSupportedException nse)
            {
                throw nse;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void cutFile(String from, String to)
        {
            try
            {
                // Tạo folder đích[from], trường hợp folder đã tồn tại thì không tạo
                new FileInfo(to).Directory.Create();

                // Move file
                File.Move(from, to);
            }
            catch (IOException ioe)
            {
                throw ioe;
            }
            catch (UnauthorizedAccessException uae)
            {
                throw uae;
            }
            catch (ArgumentException ae)
            {
                throw ae;
            }
            catch (NotSupportedException nse)
            {
                throw nse;
            }
        }
    }
}
