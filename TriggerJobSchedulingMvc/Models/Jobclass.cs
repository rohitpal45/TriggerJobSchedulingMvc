using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace TriggerJobSchedulingMvc.Models
{
        public class Jobclass : IJob
        {
            public void Execute(IJobExecutionContext context)
            {
            var task = Task.Run(() =>
            {
                try
                {
                    // string path = HttpContext.Current.Server.MapPath("~/Content/Uplaod/Simple.txt");
                    string path = System.Web.Hosting.HostingEnvironment.MapPath("~/Content/Uploads/Simple.txt");
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(string.Format("Quartz Scheduler Called on " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
                        writer.Close();
                    }
                }
                catch (Exception ex)
                {
                }
            });
        }
    }
}