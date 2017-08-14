using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Task.Service.WebServices;

namespace Task.Web.Schedules
{
    public class CurrencyJob : IJob
    {
       
        public void Execute(IJobExecutionContext context)
        {
            CurrencyService service = new CurrencyService();
            service.getCurrency();
        }
    }
}