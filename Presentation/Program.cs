using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseContext;
using Microsoft.Extensions.DependencyInjection;
using Presentation;
using Presentation.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_LAB6
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());

            //var services = new ServiceCollection();

            //ConfigureServices(services);

            //using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            //{
            //    var mainForm = serviceProvider.GetService<MainForm>();
            //    if (mainForm != null)
            //        Application.Run(mainForm);
            //    else
            //        HandleError.ShowMessageError("Не удалось запустить программу");
            //}
        }
    }
}
