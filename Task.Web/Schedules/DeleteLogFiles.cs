using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Task.Web.Framework.Services;

namespace Task.Web.Schedules
{
    public class DeleteLogFiles : IJob
    {
       
        public void Execute(IJobExecutionContext context)
        {
     
            string startPath = @"c:\TEST";
            string zipPath = @"c:\TESTZIP\" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm") + ".zip";
            bool response = Zip.ZipFileWithPath(startPath, zipPath);

        }
    }
}