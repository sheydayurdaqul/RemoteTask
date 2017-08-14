using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.IO.Compression;

//using HttpCookieEncryption;
namespace Task.Web.Framework.Services { 
    public static  class Zip
    {
        public static bool ZipFileWithPath(string startPath, string zipPath)
        {
            try
            {
                ZipFile.CreateFromDirectory(startPath, zipPath);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }


    }
}
