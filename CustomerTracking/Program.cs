using Autofac;
using CustomerTracking.DAL;
using CustomerTracking.Helpers;
using CustomerTracking.IoC;
using CustomerTracking.NonRelationalEntities;
using CustomerTracking.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTracking
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            #region Run Only One Instance (Mutex)

            bool isAppInstanceShut;

            //create mutex object
            var mutex = new Mutex(true, "CustomerTracking", out isAppInstanceShut);

            if (!isAppInstanceShut)
            {
                return;
            }

            #endregion

            #region Run Application As Administrator

            var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

            var administrativeMode = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!administrativeMode)
            {
                var startInfo = new ProcessStartInfo();
                startInfo.Verb = "runas";
                startInfo.FileName = Assembly.GetExecutingAssembly().CodeBase;

                try
                {
                    Process.Start(startInfo);
                    return;
                }
                catch
                {
                    //User denied access
                    return;
                }
            }

            #endregion

            #region IoC registration

            Injector.Configure(() =>
            {
                var builder = new ContainerBuilder();

                builder.RegisterType<Main>().As<Main>();
                builder.RegisterType<CutomerTrackingContext>().As<IDbContext>(); 
                builder.RegisterType<DataExportToPdfService>().As<IDataExportService>();

                return builder.Build();

            });

            #endregion

            #region Application Error Event Handlers

            // Add the event handler for handling UI thread exceptions
            Application.ThreadException += new ThreadExceptionEventHandler(AppExceptionHandler.CommonExceptionHandler);

            // Set the unhandled exception mode to force all Windows Forms errors to go through handler 
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppExceptionHandler.UnhandledExceptionHandler);

            #endregion

            #region Application Run Methods

            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            /// 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            #endregion

        }
    }
}
