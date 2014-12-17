using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_HotelApp.model;
using System.Drawing;
using Lab_HotelApp.console;
using System.Runtime.InteropServices;

namespace Lab_HotelApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //AttachConsole(-1);

            //Console.WriteLine("Hello World!");
            
            //Console.WriteLine(ConsoleHandler.ProcessInput(args));
            
            
            
        }

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;
    }
}
