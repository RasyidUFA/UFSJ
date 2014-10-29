using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using UFSJ.Sharp;
namespace UFSJ
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    partial class App : Application
    {
        public const string BuildDate = "16 Oct. 2014 02:57";
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            System.Windows.Forms.Application.SetUnhandledExceptionMode(System.Windows.Forms.UnhandledExceptionMode.CatchException, true);
            System.Windows.Forms.Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            System.Windows.Forms.Application.EnableVisualStyles();
            Shared.StartupEvent = e;

        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

            Exception ex = (Exception)e.ExceptionObject;
            try
            {
                string errorMsg = "An application error occurred. Please contact the adminstrator " +
                    "with the following information:\n\n";

                // Since we can't prevent the app from terminating, log this to the event log.
                if (!EventLog.SourceExists("ThreadException"))
                {
                    EventLog.CreateEventSource("ThreadException", "Application");
                }

                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog();
                myLog.Source = "ThreadException";
                myLog.WriteEntry(errorMsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
            catch (Exception exc)
            {
                try
                {
                    Shared.MSGBOX("Fatal Non-UI Error",  "Fatal Non-UI Error. Could not write the error to the event log. Reason: " + exc.Message, MessageBoxButton.OK);
                }
                finally
                {
                    Process.Start(new ProcessStartInfo("UFSJ.Crash.exe", " -ufsj \"" + ex.Message + "\" \"" + ex.StackTrace + "\""));

                    System.Windows.Forms.Application.Exit();
                }
            }

        }

        private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBoxResult result = MessageBoxResult.No;
            try
            {
               result = Shared.MSGBOX("Fatal UI ERROR", "UFSJ Was Crashed, we're sorry for this problem.\n\nWould you like to try again?", MessageBoxButton.YesNo);
            }
            catch
            {
                try
                {
                    result = Shared.MSGBOX("Fatal UI ERROR", "UFSJ Was Crashed, we're sorry for this problem.\n\nWould you like to try again?", MessageBoxButton.YesNo);
                }
                finally
                {
                    System.Windows.Forms.Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            if (result == MessageBoxResult.No)
                System.Windows.Forms.Application.Exit();


        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("UFSJ.Crash.exe", " -ufsj \"" + e.Exception.Message + "\" \"" + e.Exception.StackTrace + "\""));
                System.Windows.Forms.Application.Exit();
            } catch (Exception) {
                Application.Current.Shutdown();
            }
            
            //            if (e.Exception is NotImplementedException) {
            //                var a = Shared.MSGBOX("Oh no, it's not available yet!", "We are apologize about this problem, we will complete it in next release.", MessageBoxButton.OK);
            //                switch (a) {
            //                    case MessageBoxResult.Cancel:
            //                    case MessageBoxResult.No:
            //                    case MessageBoxResult.None:
            //                    case MessageBoxResult.OK:
            //                        return;
            //                    case MessageBoxResult.Yes:
            //                        SendErrorLog();
            //                        return;
            //                    default:
            //                        break;
            //                }
            //            } else {
            //                var a = Shared.MSGBOX("There was an error!", "We are apologize about this fault, we will fix it shortly.\n\nDo you want to send the error to UFSJ developer?", MessageBoxButton.YesNo);
            //                switch (a) {
            //                    case MessageBoxResult.Cancel:
            //                    case MessageBoxResult.No:
            //                    case MessageBoxResult.None:
            //                    case MessageBoxResult.OK:
            //                        return;
            //                    case MessageBoxResult.Yes:
            //                        SendErrorLog();
            //                        return;
            //                    default:
            //                        break;
            //                }
            //            }

        }

        internal static void SendErrorLog()
        {
            try
            {
                Shared.SendMail("togashi.yuutax@gmail.com", "230499as", "rasyid.ufasoft@gmail.com", "UFSJ Error Report", File.ReadAllText(Shared.GetData("UFSJError.log")));
            }
            catch (FileNotFoundException e)
            {
                App.Current.Shutdown(e.GetHashCode());
            }
        }

        internal static void SaveErrorLog(System.Exception e, bool shutdown = true)
        {
            try
            {
                File.AppendAllText(Shared.GetData("UFSJError.log"), DateTime.Now + " -> " + e.Message + " (" + e.InnerException.ToString() + ")\r\n");
            }
            catch (Exception)
            {
                if (shutdown) App.Current.Shutdown();
            }
        }


    }
}
