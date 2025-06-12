using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
namespace FileSplitter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());
           //Application.Run(new splitnjoin("abc"));
            ////Application.Run(new share());
            //DateTime startTime = DateTime.Now;
           // generatorEntity.PopulateValueList();
           // Thread.Sleep(2000);
           // TimeSpan elapsedTime = DateTime.Now - startTime;
        
           // Console.WriteLine("Completed! time(ticks) - " + elapsedTime.Ticks);
           // MessageBox.Show("Completed! time(ticks) - " + elapsedTime.Ticks);
        }
    }
}