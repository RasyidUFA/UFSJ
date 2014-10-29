using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace UFSJ.Sharp
{
    public class uContributor
    {
        public string Name { get; set; }
        public string Contributions { get; set; }
        public string Mail { get; set; }
    }
    static partial class Shared
    {
        internal static void ApplyThemes(ColorScheme t)
        {
            if (t.Colors == null )
            {
                return;
            }
            SolidColorBrush a = null;
            foreach (string I in t.Colors.Keys)
            {
                a = new SolidColorBrush(t.Colors[I]);
                Application.Current.Resources[I] = a;
            }
        }
        internal static List<string> FindLanguages()
        {
            string[] a;
            var LstA = new List<string>();
            if (System.IO.Directory.Exists("Languages"))
            {
                a = System.IO.Directory.GetFiles("Languages", "*.ulex");
                foreach (var i in a)
                {
                    var u = new System.IO.FileInfo(i).Name;
                    u = u.Remove(u.LastIndexOf('.'));
                    LstA.Add(u);
                }
            }
            try
            {
                if (System.IO.Directory.GetFiles(Shared.LocalData("Languages")).Length > 0)
                {
                    a = System.IO.Directory.GetFiles(Shared.LocalData("Languages\\"), "*.ulex");
                    foreach (var i in a)
                    {
                        var u = new System.IO.FileInfo(i).Name;
                        u = u.Remove(u.LastIndexOf('.'));
                        if (LstA.Contains(u)) LstA.Remove(u);
                        LstA.Add(u);
                    }
                }
            }
            catch (Exception)
            {
                return LstA;
            }

            return LstA;
        }
        internal static string GetVersion(Version version)
        {
            switch (version.Major)
            {
                case 5:
                    switch (version.Minor)
                    {
                        case 0: return "Windows 2000";
                        case 1: return "Windows XP";
                        case 2: return "Windows Server 2003";
                    }
                    break;
                case 6:
                    switch (version.Minor)
                    {
                        case 0: return "Windows Vista";
                        case 1: return "Windows 7";
                        case 2: return "Windows 8";
                        case 3: return "Windows 8.1";
                    }
                    break;
                default:
                    return "Unknown";
            }
            return "Unknown";
        }
        internal static Dictionary<String, ColorScheme> Schemes = null;

        internal static int CurrentTab { get; set; }

        internal static bool SendMail(string sender, string password, string reciver, string subject, string text)
        {
            var smtpServer = new SmtpClient();
            var mail = new MailMessage();
            smtpServer.Credentials = new NetworkCredential(sender, password);
            smtpServer.Port = 587;
            smtpServer.Host = "smtp.gmail.com";
            smtpServer.EnableSsl = true;
            smtpServer.Send(new MailMessage { From = new MailAddress(sender), To = { reciver }, Subject = subject, Body = text });
            return true;
        }
        internal static string[] getMergeFiles(string Filename, out string[] NotFoundFiles, bool getnotfounds = true)
        {
            string[] _tempFiles = Directory.GetFiles(Directory.GetParent(Filename).FullName, Shared.GetFNWoExt(Filename) + ".*??");
            string[] _MergeFiles = null;
            NotFoundFiles = null;
            string merged = "";
            short notfound = 1;
            // BUGFIX : Error when enumrating last (almost all cases) 
            for (int i = 1; i <= _tempFiles.Length; i++)
            {
                merged = Filename + "." + i.ToString("000");
                if (Array.BinarySearch(_tempFiles, merged) >= 0)
                {
                    Array.Resize(ref _MergeFiles, i);
                    _MergeFiles[i - 1] = merged;
                }
                else
                {
                    if (getnotfounds)
                    {
                        Array.Resize(ref NotFoundFiles, notfound);
                        NotFoundFiles[notfound - 1] = merged;
                    }
                    notfound += 1;
                }
            }
            return _MergeFiles;
        }

        internal static void UpdateProgress(ProgressBar PB, double mainprogress, string status, string childstatus = "", double childprogress = 0, double elapsed = 0, double remaining = 0, long size = 0)
        {
            var ti = new TaskInformation(status, childstatus, mainprogress, childprogress, elapsed, remaining, size);
            if (mainprogress >= 0)
            {
                PB.IsIndeterminate = false;
                PB.Tag = ti;
                PB.Value = Math.Round(mainprogress, 1);
            }
            else
            {
                PB.Tag = ti;
                PB.Value = Math.Round(Math.Abs(mainprogress), 1);
                PB.IsIndeterminate = true;
            }
            System.Windows.Forms.Application.DoEvents();
        }

        internal static string GetRes(string p)
        {
            return Application.Current.FindResource(p).ToString();
        }
        internal static string GetRes(string p1, string p2)
        {
            try
            {
                return GetRes(p1);
            }
            catch (Exception)
            {
                return p2;
            }
        }
        internal static int[] PageParse(string p)
        {
            var i = new List<int>();
            var strs = p.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (var m in strs)
                {
                    if (m.Contains("-") || m.Contains("_") || m.Contains("..."))
                    {
                        var a = m.Split(new[] { "-", "_", "..." }, StringSplitOptions.RemoveEmptyEntries);
                        if (a.Length != 2)
                            throw new InvalidOperationException("Invalid Format : Invalid length");

                        int a1 = int.Parse(a[0]);
                        int a2 = int.Parse(a[1]);
                        if (a1 > a2) { var t = a1; a1 = a2; a2 = t; }
                        for (int r = a1; r <= a2; r++)
                        {
                            if (!i.Contains(r))
                            {
                                i.Add(r);
                            }
                        }
                    }
                    else
                    {
                        if (!i.Contains(int.Parse(m)))
                        {
                            i.Add(int.Parse(m));
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Invalid Format");
            }

            return i.ToArray();

        }

        public static bool IsPortable { get; set; }

        public static bool MSGBOX(string p, System.Windows.Window owner = null)
        {
            var Msg = new Windows.MessageWnd(Shared.GetRes("#D.01#", "Information"), p, MessageBoxButton.OK);
            Msg.Owner = owner;
            return (Msg.ShowDialog() == true);
        }


        public static bool MSGBOX(string title, string description, System.Windows.Window owner = null)
        {
            var Msg = new Windows.MessageWnd(title, description, MessageBoxButton.OK);
            Msg.Owner = owner;
            return (Msg.ShowDialog() == true);
        }
        public static MessageBoxResult MSGBOX(string title, string description, MessageBoxButton button, System.Windows.Window owner = null)
        {
            var Msg = new Windows.MessageWnd(title, description, button);
            Msg.Owner = owner;
            Msg.ShowDialog();
            return Msg.Result;
        }
        internal static void RemoveAssoc()
        {
            var a = new FileType("001", "UFSJ.001", "UFSJ Split File", "%APP%, 1", "%APP% -tj \"%1\"");
            if (a.CheckForRegistration())
            {
                a.RemoveRegistration();
            }
        }

        internal static void AddAssoc()
        {
            var a = new FileType("001", "UFSJ.001", "UFSJ Split File", "%APP%, 1", "%APP% -j \"%1\"");
            a.AddRegistration(true);
        }

        public static bool LoadSilent { get; set; }

        public static StartupEventArgs StartupEvent { get; set; }
    }
}
