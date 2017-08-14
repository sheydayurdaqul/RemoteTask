using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Quartz.Impl;

namespace Task.Web.Schedules
{
    public class JobScheduler
    {
        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            IJobDetail jobCurrecy = JobBuilder.Create<CurrencyJob>().Build();
            IJobDetail jobZip = JobBuilder.Create<DeleteLogFiles>().Build();
            ITrigger triggerDay = TriggerBuilder.Create()
                .WithDailyTimeIntervalSchedule
                  (s =>
                     s.WithIntervalInHours(24)
                    .OnEveryDay()
                    .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(0, 0))
                  )
                .Build();
            ITrigger triggerWeek = TriggerBuilder.Create()
             .WithDailyTimeIntervalSchedule
               (s =>
                  s.WithIntervalInHours(12)
                 .OnEveryDay()
                 .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(0, 0))
               )
             .Build();
            scheduler.ScheduleJob(jobCurrecy, triggerDay);
            scheduler.ScheduleJob(jobZip, triggerWeek);


        }
    }
}