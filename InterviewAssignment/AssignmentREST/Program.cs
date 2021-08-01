using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentREST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //public void wait(int milliseconds)
        //{
        //    //This function can be called to introduce a waiting time before Events are continued
        //    var timer1 = new System.Windows.Forms.Timer();
        //    if (milliseconds == 0 || milliseconds < 0) return;

        //    // Console.WriteLine("start wait timer");
        //    timer1.Interval = milliseconds;
        //    timer1.Enabled = true;
        //    timer1.Start();

        //    timer1.Tick += (s, e) =>
        //    {
        //        timer1.Enabled = false;
        //        timer1.Stop();
        //        // Console.WriteLine("stop wait timer");
        //    };

        //    while (timer1.Enabled)
        //    {
        //        Application.DoEvents();
        //    }
        //}
    }
}
