using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using UFSJ.Sharp;
using UFSJ.Sharp.Task;
using SIO = System.IO;
namespace UFSJ
{
    /// <summary>
    /// Interaction logic for MainWnd.xaml
    /// </summary>
    partial class MainWnd : Window
    {
        public bool Shutdown
        {
            get;
            set;
        }

        internal string CurrentScheme { get; set; }
        int CurrentEventIndex;
        Language CurrentLanguage;

        /// <summary>
        /// Initilaize new MainWondow
        /// </summary>
        public MainWnd()
        {
            InitializeComponent();

        }
        void ApplyLanguages()
        {
            if (CurrentLanguage == null) return;

            if (CurrentLanguage != null && CurrentLanguage.strings != null)
            {
                foreach (var item in CurrentLanguage.strings)
                {
                    Application.Current.Resources[item.Key] = item.Value;
                }
            }
            else
            {
                throw new Exception("Language error, no language selected");

            }
        }
        void InitializeLanguage()
        {
            fileAppLanguage.Items.Clear();
            var LstA = new List<string>();
            LstA = Shared.FindLanguages();
            foreach (var u in LstA)
            {
                fileAppLanguage.Items.Add(new Language(u));
            }

        }

        void InitializeSchemes()
        {
            fileAppTheme.Items.Clear();
            foreach (var v in Shared.Schemes.Keys)
            {
                if (v != null) fileAppTheme.Items.Add(v);
            }
            if (fileAppTheme.Items.Count == 0)
            {
                Shared.Schemes.Add("Default", ColorScheme.DefaultTheme());
                fileAppTheme.Items.Add("Dark Blue (Default)");
                fileAppTheme.SelectedIndex = 0;
                var c = new ComboBoxItem();
                c.Content = "UFSJ Theme not founds.";
                c.IsEnabled = false;
                fileAppTheme.Items.Add(c);
            }
        }
        void InitializePreDef()
        {
            Shared.PresentLoad();
            var temp = Shared.PresentSplit;
            foreach (var item in temp.Keys)
            {
                var a = new ComboBoxItem();
                a.Content = item;
                a.Tag = temp[item];
                if ((double)temp[item][1] == 4)
                {
                    a.Background = cSplitParts.Background;
                }
                splitOptComboPreDef.Items.Add(a);
            }
        }

        void ParseCommands(StartupEventArgs e)
        {

            Debug.WriteLine("Parsing Commandline()");
            var arg = "";
            for (int i = 0; i < e.Args.Length; i++)
            {
                arg = e.Args[i];
                switch (arg.Substring(0, 1))
                {
                    case "-":
                        switch (arg.Substring(1, 1))
                        {
                            case "t":
                                switch (arg.Substring(3, 1))
                                {
                                    case "c":
                                        Shared.CurrentTab = 3;
                                        break;
                                    case "j":
                                        Shared.CurrentTab = 2;
                                        break;
                                    case "s":
                                        Shared.CurrentTab = 1;
                                        break;
                                }
                                break;
                            case "s":
                                Shared.LoadSilent = true;
                                break;
                        }

                        break;
                    case "\"":
                        var ext = new SIO.FileInfo(arg.Trim('"')).Extension;
                        switch (ext)
                        {
                            case "001":
                            case "ufsx":
                            case "ufs":
                            case "h001":
                                Shared.CurrentTab = 2;
                                joinInPath.Text = arg.Trim('"');
                                // AddSplittingTask;
                                break;
                            case "md5":
                            case "sha":
                            case "crc32":
                            case "ufh":
                                Shared.CurrentTab = 3;
                                hashInPath.Text = arg.Trim('"');
                                // Add Comparing Task;
                                break;
                            default:
                                Shared.CurrentTab = 1;
                                splitInPath.Text = arg.Trim('"');
                                break;
                        }
                        break;
                }

            }
        }


        private void InitializePortability()
        {
            var asd = Stopwatch.StartNew();
            Debug.WriteLine("Initializing Portability Check()");

            var di = new SIO.DirectoryInfo(Environment.CurrentDirectory);
            var progfiledir = Environment.GetEnvironmentVariable("PROGRAMFILES");
            if (SIO.File.Exists("[portable]"))
            {
                Shared.IsPortable = true;
                fileOptPortConvertStatus.Text = Shared.GetRes("#M.03#");
                fileOptPortConvert.IsEnabled = true;
            }
            else if (di.Parent.FullName == progfiledir)
            {
                Shared.IsPortable = false;
                fileOptPortConvertStatus.Text = Shared.GetRes("#M.04#");
                fileOptPortConvert.IsEnabled = false;
            }
            else
            {
                Shared.IsPortable = false;
                fileOptPortConvertStatus.Text = Shared.GetRes("#M.05#");
                fileOptPortConvert.IsEnabled = true;
            }
        }


        #region Local Procedures

        void InitializePersonalization()
        {
            var asd = Stopwatch.StartNew();
            Debug.WriteLine("Initializing Personalization()");

            OperatingSystem os = Environment.OSVersion;
            string s = String.Format("OS: {0} ({1}) \n", Shared.GetVersion(os.Version), os.Version);

            s += String.Format("User: {0} \n", Environment.UserName);
            s += String.Format("Memory Used: {0} \n", Shared.GetSizeWithLabel(Environment.WorkingSet));
            OsInfo.Content = s;

            Assembly assem = Assembly.GetEntryAssembly();
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;
            AboutVersion.Content = String.Format(Shared.GetRes("#S.22#") + " {0}.{1}.{2} Build {3} ( {4} )", ver.Major, ver.Minor, ver.Build, ver.Revision, App.BuildDate);

        }



        void StartPartSplit(bool mode = true)
        {

            cSplit.Increment = mode;
            cSplit.StartPart();
        }
        void StartSplit()
        {
            cSplit.Start();
        }

        void LoadSetting()
        {
            WindowStartupLocation = WindowStartupLocation.Manual;
            if (Shared.Setting.Position != new Point(0, 0))
            {
                Left = Shared.Setting.Position.X;
                Top = Shared.Setting.Position.Y;
            }
            if (Shared.CurrentTab < 4 && Shared.CurrentTab > 0) mainTab.SelectedIndex = Shared.CurrentTab;

            FileOptOntop.IsChecked = Shared.Setting.OnTopMost;
            FileOptHideProgress.IsChecked = Shared.Setting.SilentProgress;
            FileOptShowInfo.IsChecked = Shared.Setting.ShowSummary;
            fileSettingAssociateExt.IsChecked = Shared.Setting.AssociateExt;  //AssociateExt
            fileSettingStartSilent.IsChecked = Shared.Setting.StartHide; //StartHide
            fileSettingIntergrate.IsChecked = Shared.Setting.ShellMenus; //ShellMenus
            // cf  = Shared.Setting.SettingMode; //SettingMode
            fileSettingFormat.Text = Shared.Setting.Formats; //Formats


            System.Windows.Forms.Application.DoEvents();
            fileAppTheme.Text = Shared.Setting.Theme; //ColorScheme
            System.Windows.Forms.Application.DoEvents();
            fileAppLanguage.Text = Shared.Setting.Language; //Language
        }
        void SaveSettings()
        {
            Shared.Setting.OnTopMost = this.Topmost;
            Shared.Setting.ShowSummary = (bool)FileOptShowInfo.IsChecked;
            Shared.Setting.SilentProgress = (bool)FileOptHideProgress.IsChecked;
            Shared.Setting.AssociateExt = (bool)fileSettingAssociateExt.IsChecked; //AssociateExt
            Shared.Setting.StartHide = (bool)fileSettingStartSilent.IsChecked; //StartHide
            Shared.Setting.ShellMenus = (bool)fileSettingIntergrate.IsChecked; //ShellMenus
            Shared.Setting.SettingMode = 3; //SettingMode
            Shared.Setting.Theme = fileAppTheme.Text ?? ""; //ColorScheme
            Shared.Setting.Language = fileAppLanguage.Text ?? ""; //Language
            Shared.Setting.Formats = fileSettingFormat.Text; //Formats
            Shared.Setting.Position = new Point(this.Left, this.Top);
            try
            {
                Shared.Setting.Save();
            }
            catch (ArgumentNullException)
            {
                throw new Exception("There was error saving data, the option cannot be null at MainWnd.cs");
            }
        }
        void DoTaskGetJoinSize(TextBox Input, Label Output)
        {

            try
            {
                long sz = 0;
                string[] nf;
                string r = Shared.GetFNWoExt(Input.Text, true);
                var a = Shared.getMergeFiles(r, out nf, false);
                foreach (var i in a)
                {
                    sz += Shared.FileSize(i);
                }

                if (SIO.File.Exists(Input.Text))
                {
                    Output.Content = String.Format("Size: {0} | {1} Pieces", Shared.GetSizeWithLabel(sz), a.Length);
                    Output.Opacity = 1;
                }
                else
                {
                    Output.Content = "Size: Unknown";
                    Output.Opacity = 0.3;
                }
            }
            catch
            {
                Output.Content = "Size: Unknown";
                Output.Opacity = 0.3;
                return;
            }
        }
        void DoTaskGetSize(TextBox Input, ContentControl Output)
        {
            try
            {

                if (SIO.File.Exists(Input.Text))
                {
                    Output.Content = "Size: " + Shared.GetSizeWithLabel(Shared.FileSize(Input.Text));
                    Output.Opacity = 1;
                }
                else
                {
                    Output.Content = "Size: Unknown";
                    Output.Opacity = 0.3;
                }
            }
            catch
            {
                Output.Content = "Size: Unknown";
                Output.Opacity = 0.3;
                return;
            }
        }
        void DoTaskGetFree(TextBox Input, ContentControl Output, Button ODir)
        {
            try
            {
                var dir = SIO.Directory.GetDirectoryRoot(Input.Text);
                if (String.IsNullOrEmpty(dir))
                {
                    Output.Content = "Free: " + Shared.GetSizeWithLabel(Shared.FreeSpace(dir));
                    Output.Opacity = 1;
                }
                else
                {
                    Output.Content = "Free: Unknown";
                    Output.Opacity = 0.3;
                }
                ODir.IsEnabled = SIO.Directory.Exists(SIO.Directory.GetParent(Input.Text).FullName);

            }
            catch
            {
                Output.Content = "Free: Unknown";
                Output.Opacity = 0.3;
                return;
            }
        }
        void ResetTaskBarInfo()
        {
            TaskBarInfo.Description = "";
            TaskBarInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.None;
            TaskBarInfo.ProgressValue = 0;

        }
        void OpenDirectory(string path)
        {
            if (SIO.File.Exists(path) == false) return;
            var s = "\"" + SIO.Directory.GetParent(path).FullName + "\\\"";
            var a = @"C:\Windows\explorer.exe ";
            Process.Start(new ProcessStartInfo(a, s));
        }


        string OpenFileDlg(string title, string filter)
        {
            var retval = "";
            var ofd = new OpenFileDialog();
            ofd.Title = title; ofd.Filter = filter;
            if (ofd.ShowDialog() == true)
                retval = ofd.FileName;
            ofd = null;
            return retval;
        }
        string SaveFileDlg(string title, string filter, string filename = "")
        {
            var retval = "";
            var ofd = new SaveFileDialog();
            ofd.Title = title; ofd.Filter = filter; ofd.FileName = filename;
            if (ofd.ShowDialog() == true)
                retval = ofd.FileName;
            ofd = null;
            return retval;
        }
        bool InitializeHash()
        {

            Debug.WriteLine("(re)initialize Hash Status");
            cHash.gcrc32s = (bool)hashOptCRC32.IsChecked; cHash.gmd5s = (bool)hashOptMD5.IsChecked;
            cHash.gsha1s = (bool)hashOptSHA1.IsChecked; cHash.gsha256s = (bool)hashOptSHA2.IsChecked;
            cHash.gsha384s = (bool)hashOptSHA3.IsChecked; cHash.gsha512s = (bool)hashOptSHA4.IsChecked;

            hashOutA1.IsEnabled = cHash.gcrc32s; hashOutA2.IsEnabled = cHash.gmd5s;
            hashOutA3.IsEnabled = cHash.gsha1s; hashOutA4.IsEnabled = cHash.gsha256s;
            hashOutA5.IsEnabled = cHash.gsha384s; hashOutA6.IsEnabled = cHash.gsha512s;

            var a = new List<int>();
            if (cHash.gcrc32s) a.Add(0); if (cHash.gmd5s) a.Add(1);
            if (cHash.gsha1s) a.Add(2); if (cHash.gsha256s) a.Add(3);
            if (cHash.gsha384s) a.Add(4); if (cHash.gsha512s) a.Add(5);

            if (a.Count != 0)
            {
                a.Sort(); hashOutAlgol.SelectedIndex = a[0]; return true;
            }
            else
            {
                hashOutAlgol.Text = "none"; return false;
            }
        }
        long GetChunk(string tSplitSize, string tPathIn)
        {
            var a = (long)0;
            var b = Shared.FileSize(tPathIn);
            var ui = Convert.ToUInt32(tSplitSize);
            switch (splitOptSizeC.SelectedIndex)
            {

                case 1:
                    a = ui * (1024);
                    break;
                case 2:
                    a = ui * (long)Math.Pow(1024, 2);
                    break;
                case 3:
                    a = ui * (long)Math.Pow(1024, 3);
                    break;
                case 4:
                    a = b / ui + b % ui;
                    break;
                case 0:
                default:
                    a = ui;
                    break;
            }
            return a;
        }

        #endregion

        #region Tasks

        #region Button - IO Browse & Open

        void SpltBrowseIn_Click(object sender, RoutedEventArgs e)
        {
            var title = "Select File To Split";
            var filter = "All Files |*.*";
            splitInPath.Text = OpenFileDlg(title, filter);
        }
        void JoinBrowseIn_Click(object sender, RoutedEventArgs e)
        {
            var title = "Select File To Join";
            var filter = "First Part|*.001|Any part|*.???";
            joinInPath.Text = OpenFileDlg(title, filter);
        }
        void HashBrowseIn_Click(object sender, RoutedEventArgs e)
        {
            var title = "Select File To Calculate Hash";
            var filter = "All Files |*.*";
            hashInPath.Text = OpenFileDlg(title, filter);
        }
        void diffInBrowse_Click(object sender, RoutedEventArgs e)
        {
            diffInPath.Text = OpenFileDlg("Select File To Campare", "All Files |*.*");
        }
        void SpltBrowseOut_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(splitInPath.Text))
            {
                var i = new SIO.FileInfo(splitInPath.Text);
                splitOutPath.Text = SaveFileDlg("Save Split Parts", "Split Part|.001", i.Name);
            }
            else
                splitOutPath.Text = SaveFileDlg("Save Split Parts", "Split Part|.001");

        }
        void JoinBrowseOut_Click(object sender, RoutedEventArgs e)
        {
            var Filter = "";
            if (!String.IsNullOrEmpty(joinInPath.Text))
            {
                var i = new SIO.FileInfo(Shared.GetFNWoExt(joinInPath.Text));
                Filter = String.Format("{0}|*{1}", i.Name, i.Extension);
                joinOutPath.Text = SaveFileDlg("Save Split Parts", Filter, i.Name);
                return;
            }
        }
        void HashBrowseOut_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(hashInPath.Text))
            {
                var i = new SIO.FileInfo(Shared.GetFNWoExt(hashInPath.Text));
                hashOutPath.Text = SaveFileDlg("Save Generated Checksum", "Generated Checksum (*.txt)|*.txt", i.Name);
                return;
            }

        }
        void diffOutBrowse_Click(object sender, RoutedEventArgs e)
        {
            diffOutPath.Text = OpenFileDlg("Select Comparer", "All Files |*.*");
        }

        void spltOpenOutDir_Click(object sender, RoutedEventArgs e)
        {
            OpenDirectory(splitOutPath.Text);
        }
        void joinOpenOutDir_Click(object sender, RoutedEventArgs e)
        {
            OpenDirectory(joinOutPath.Text);
        }
        void hashOpenOutDir_Click(object sender, RoutedEventArgs e)
        {
            OpenDirectory(hashOutPath.Text);
        }
        void diffOpenOutDir_Click(object sender, RoutedEventArgs e)
        {
            OpenDirectory(diffOutPath.Text);
        }

        #endregion

        void spltStart_Click(object sender, RoutedEventArgs e)
        {
            ResetTaskBarInfo();
            if (String.IsNullOrEmpty(splitInPath.Text)) { SpltBrowseIn_Click(sender, e); return; }
            if (String.IsNullOrEmpty(splitOutPath.Text)) splitOutPath.Text = splitInPath.Text + ".001";
            cSplit.FileName = splitInPath.Text;
            cSplit.OutputPath = SIO.Directory.GetParent(splitOutPath.Text).FullName;
            cSplit.ChunkSize = GetChunk(splitOptSizeT.Text, splitInPath.Text);
            if (cSplit.ChunkSize == 0)
            {
                Shared.MSGBOX(Shared.GetRes("#D.02#", "Error"), "Please enter valid size", this);
                splitOptSizeT.Focus();
                return;
            }
            cSplit.CompressParts = (bool)splitOptCompress.IsChecked;
            cSplit.PB = prgStatus;
            cSplit.DeleteFileAfterSplit = (bool)splitOptDelete.IsChecked;
            cSplit.GenerateJoiner = (bool)splitOptBatch.IsChecked;

            CurrentEventIndex = 1;
            switch (splitOptGenerate.SelectedIndex)
            {
                case 0:
                    StartSplit();
                    break;
                case 1:
                    cSplit.GeneratedPart = Shared.PageParse("1-" + splitOptGenerateValue.Text);
                    StartPartSplit();
                    break;
                case 2:
                    cSplit.GeneratedPart = Shared.PageParse("1-" + splitOptGenerateValue.Text);
                    StartPartSplit(false);
                    break;
                case 3:
                    cSplit.GeneratedPart = Shared.PageParse(splitOptGenerateValue.Text);
                    StartPartSplit();
                    break;
            }

        }
        void joinStart_Click(object sender, RoutedEventArgs e)
        {
            ResetTaskBarInfo();
            if (String.IsNullOrEmpty(joinInPath.Text)) { JoinBrowseIn_Click(sender, e); return; }

            cMerge.FileName = Shared.GetFNWoExt(joinInPath.Text, true);
            cMerge.OutputPath = joinOutPath.Text;
            cMerge.PB = prgStatus;
            cMerge.DeleteFilesAfterMerge = (bool)joinOptDelete.IsChecked;
            CurrentEventIndex = 2;
            cMerge.Start();
        }
        void hashStart_Click(object sender, RoutedEventArgs e)
        {
            ResetTaskBarInfo();
            if (String.IsNullOrEmpty(hashInPath.Text)) { HashBrowseIn_Click(sender, e); return; }
            if (InitializeHash() == false) return;
            cHash.gSHAAlgol = (cHash.gsha1s || cHash.gsha256s || cHash.gsha384s || cHash.gsha512s);
            cHash.Filename = hashInPath.Text;
            cHash.OutputPath = hashOutPath.Text;
            cHash.PB = prgStatus;
            CurrentEventIndex = 3;
            cHash.Calculate();
            hashOutView_Click(sender, e);
        }
        void diffStart_Click(object sender, RoutedEventArgs e)
        {
            ResetTaskBarInfo();
            try
            {
                if (String.IsNullOrEmpty(diffInPath.Text)) { diffInBrowse_Click(sender, e); return; }
                cDiff.Filename = diffInPath.Text;
                cDiff.DiffFilename = diffOutPath.Text;
                cDiff.PB = prgStatus;
                CurrentEventIndex = 4;
                Shared.MSGBOX(Shared.GetRes("#D.01#"), cDiff.Compare(), this);
            }
            catch (Exception)
            {
                throw;
            }
        }

        void hashOutView_Click(object sender, RoutedEventArgs e)
        {
            var a = "";
            switch (hashOutAlgol.Text)
            {
                case "CRC32":
                    a = cHash.crc32s;
                    break;
                case "MD5":
                    a = cHash.md5s;
                    break;
                case "SHA-1":
                    a = cHash.sha1s;
                    break;
                case "SHA-256":
                    a = cHash.sha256s;
                    break;
                case "SHA-384":
                    a = cHash.sha384s;
                    break;
                case "SHA-512":
                    a = cHash.sha512s;
                    break;
                default:
                    a = "none";
                    break;
            }
            hashOutT.Text = a;
        }
        void hashOutCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(hashOutT.Text, TextDataFormat.Text);
        }
        void hashOutT_TextChanged(object sender, TextChangedEventArgs e)
        {
            hashOutCopy.IsEnabled = !String.IsNullOrEmpty(hashOutT.Text);
        }

        #region Size Information
        void diffInPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoTaskGetSize(diffInPath, diffInSize);
        }
        void diffOutPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoTaskGetSize(diffOutPath, diffOutSize);
        }
        void hashOutPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoTaskGetFree(hashOutPath, hashOutSize, hashOpenOutDir);
        }
        void hashInPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoTaskGetSize(hashInPath, hashInSize);
        }
        void joinInPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoTaskGetJoinSize(joinInPath, joinInSize);
        }

        void joinOutPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoTaskGetFree(joinOutPath, joinOutSize, joinOpenOutDir);
        }
        void splitPathIn_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoTaskGetSize(splitInPath, splitInSize);
        }
        void splitPathOut_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoTaskGetFree(splitOutPath, splitOutSize, splitOpenOutDir);
        }
        #endregion

        void splitOptGenerate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (splitOptGenerate.SelectedIndex)
            {
                case 0:
                    splitOptGenerateValue.Visibility = System.Windows.Visibility.Hidden;
                    splitOptGenerateLabel.Visibility = System.Windows.Visibility.Hidden;
                    break;
                case 1:
                case 2:
                case 3:
                    splitOptGenerateValue.Visibility = System.Windows.Visibility.Visible;
                    splitOptGenerateLabel.Visibility = System.Windows.Visibility.Visible;
                    break;
            }
        }
        void splitPreManage_Click(object sender, RoutedEventArgs e)
        {
            var w = new PresentWindow();
            w.Owner = this;
            w.ShowDialog();
        }

        #endregion

        #region Options

        private void bSaveSetting_Click(object sender, RoutedEventArgs e)
        {
            SaveSettings();
        }
        void chkOntop_Click(object sender, RoutedEventArgs e)
        {
            this.Topmost = (bool)FileOptOntop.IsChecked;
        }
        void cPresent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var b = ((ComboBoxItem)splitOptComboPreDef.SelectedItem).Tag;
            var list = b as List<object>;
            if (list != null)
            {
                var a = list;
                splitOptSizeT.Text = a[0].ToString();
                splitOptSizeC.SelectedIndex = (int)Convert.ToUInt32(a[1]);
            }
        }
        void fileAppThemeR_Click(object sender, RoutedEventArgs e)
        {
            var a = fileAppTheme.SelectedIndex;
            InitializeSchemes();
            fileAppTheme.SelectedIndex = a;
        }
        void fileCDefs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (fileCDefs.SelectedIndex)
            {
                case 0:
                    fileSettingFormat.Text = "[fn].[idx].ufs";
                    break;
                case 1:
                    fileSettingFormat.Text = "[fn].[idxh].ufsx";
                    break;
                case 2:
                    fileSettingFormat.Text = "[fn].[idx].[ext]";
                    break;
                case 3:
                    fileSettingFormat.Text = "[fn].[ext].[idx]";
                    break;
                case 4:
                default:
                    break;
            }

        }
        void fileAppTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fileAppTheme.SelectedValue == null || CurrentScheme == fileAppTheme.SelectedValue.ToString())
            {
                return;
            }
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (fileAppTheme.SelectedItem == null) return;
            CurrentScheme = fileAppTheme.SelectedItem.ToString();
            if (!Shared.Schemes.ContainsKey(CurrentScheme))
            {
                //Shared.MSGBOX(Shared.GetRes("#D.02#", "Error"), "Theme not Loaded", MessageBoxButton.OK, this);
                return;
            }
            var t = Shared.Schemes[CurrentScheme];
            Shared.ApplyThemes(t);
        }




        void fileAppLangM_Click(object sender, RoutedEventArgs e)
        {
            var w = new LangMgrWnd();
            w.Owner = this;
            w.ShowDialog();
            var t = fileAppLanguage.Text;
            InitializeLanguage();
            fileAppLanguage.Text = t;
            fileAppLangA_Click(sender, e);
        }
        void fileAppLangA_Click(object sender, RoutedEventArgs e)
        {
            var a = (Language)fileAppLanguage.SelectedItem;
            CurrentLanguage = a ?? null;
            ApplyLanguages();
        }
        void FileOptShowInfo_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveSettings();
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Behavior


        void JoinGrid_DragEnter(object sender, DragEventArgs e)
        {

            e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
        }
        void HashGrid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
        }
        void Label_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
        }
        void Grid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
        }
        void SecondComp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
        }

        void HashGrid_Drop(object sender, DragEventArgs e)
        {
            var file = ((String[])e.Data.GetData(DataFormats.FileDrop, true));
            hashInPath.Text = file[0];
        }
        void Label_Drop(object sender, DragEventArgs e)
        {
            var file = ((String[])e.Data.GetData(DataFormats.FileDrop, true));
            diffInPath.Text = file[0];
        }
        void SecondComp_Drop(object sender, DragEventArgs e)
        {
            var file = ((String[])e.Data.GetData(DataFormats.FileDrop, true));
            diffOutPath.Text = file[0];
        }
        void Grid_Drop(object sender, DragEventArgs e)
        {
            var file = ((String[])e.Data.GetData(DataFormats.FileDrop, true));
            splitInPath.Text = file[0];
        }
        private void JoinGrid_Drop(object sender, DragEventArgs e)
        {
            var file = ((String[])e.Data.GetData(DataFormats.FileDrop, true));
            joinInPath.Text = file[0];
        }
        void prgStatus_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            TaskBarInfo.ProgressState = prgStatus.IsIndeterminate ? System.Windows.Shell.TaskbarItemProgressState.Indeterminate : System.Windows.Shell.TaskbarItemProgressState.Normal;

            var taskInformation = prgStatus.Tag as TaskInformation;
            if (taskInformation != null)
            {
                taskMainProgress.Maximum = prgStatus.Maximum;
                mainTab.SelectedIndex = 5;
                ((TabItem)mainTab.Items[5]).Visibility = System.Windows.Visibility.Visible;
                var t = taskInformation;
                siStatus.Content = t.MainStatus;
                taskChildStatus.Content = t.ChildStatus;
                taskMainStatus.Content = t.MainStatus;
                taskMainProgress.Value = Math.Round(t.MainProgress, 2);
                taskChildProgress.Value = Math.Round(t.ChildProgress, 2);
                taskElapsed.Content = "Elapsed :" + TimeSpan.FromMilliseconds(t.Elapsed);
                taskSize.Content = Shared.GetSizeWithLabel(t.ChildSize);
                taskProgress.Content = Math.Round((prgStatus.Value / prgStatus.Maximum * 100), 2) + " %";

                if (t.MainStatus == "Ready")
                {
                    mainTab.SelectedIndex = CurrentEventIndex;
                    ((TabItem)mainTab.Items[5]).Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            else
            {
                var str = prgStatus.Tag as string;
                if (str != null)
                {
                    siStatus.Content = str;
                    if (str == "Error")
                    {
                        TaskBarInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.Error;
                    }
                }
            }
            TaskBarInfo.ProgressValue = prgStatus.Value / prgStatus.Maximum;

        }
        void mainWindow_Deactivated(object sender, EventArgs e)
        {
            SaveSettings();
        }
        void mainWindow_LocationChanged(object sender, EventArgs e)
        {
            Shared.Setting.Position = new Point(this.Left, this.Top);
        }

        #endregion

        #region About
        void imgSMP_MouseMove(object sender, MouseEventArgs e)
        {
            lInformationSupport.Content = "SMP N 1 Parakan,\nTemanggung";
        }
        void imgKIR_MouseMove(object sender, MouseEventArgs e)
        {
            lInformationSupport.Content = "KIR SMP N 1 Parakan";
        }
        void imgUFSJ_MouseMove(object sender, MouseEventArgs e)
        {
            lInformationSupport.Content = "UFSJ Projects 2014";
        }
        void imgUFASoft_MouseMove(object sender, MouseEventArgs e)
        {
            lInformationSupport.Content = "UFASoft Technology org.";
        }
        #endregion

        private void fileOptPortConvert_Click(object sender, RoutedEventArgs e)
        {
            if (!Shared.IsPortable)
            {
                var a = new SIO.StreamWriter("[portable]", false);
                a.Write("this file indicate that the executable is portable.");
                a.Close();
                SIO.File.SetAttributes("[portable]", SIO.FileAttributes.NotContentIndexed);
                SIO.File.SetAttributes("[portable]", SIO.FileAttributes.ReadOnly);
                // SIO.File.SetAttributes("[portable]", SIO.FileAttributes.Device);
                SIO.File.SetAttributes("[portable]", SIO.FileAttributes.System);
                SIO.File.SetAttributes("[portable]", SIO.FileAttributes.Hidden);
            }
            else
            {
                SIO.File.Delete("[portable]");
            }
            InitializePortability();
        }

        private void fileSettingAssociateExt_Checked(object sender, RoutedEventArgs e)
        {
            switch ((bool)fileSettingAssociateExt.IsChecked)
            {
                case true:
                    Shared.AddAssoc();
                    break;
                case false:
                    Shared.RemoveAssoc();
                    break;
            }
        }

        private void fileSettingStartSilent_Checked(object sender, RoutedEventArgs e)
        {
            Shared.LoadSilent = (bool)fileSettingStartSilent.IsChecked;
        }

        private void hashSaveRes_Checked(object sender, RoutedEventArgs e)
        {
            throw new Exception("Error handler testing project.", new Exception("This is Unavailable"));
        }

        private void mainWindow_Activated(object sender, EventArgs e)
        {

        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {

        }

        private void mainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Shutdown)
            {
                e.Cancel = true;
                this.Hide();
            }

            if (Application.Current.MainWindow != null)
            {
                Application.Current.MainWindow.Show();
            }
        }

        private void TITLEBAR_Drag(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void PART_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PART_MAXIMIZE_RESTORE_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == System.Windows.WindowState.Normal ? System.Windows.WindowState.Maximized : System.Windows.WindowState.Normal;
        }

        private void PART_MINIMIZE_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var c = new UFSJ.Resources.Contributors();
            lstContrib.ItemsSource = c.Names;
            // After this ya!
            ParseCommands(Shared.StartupEvent);
            System.Windows.Forms.Application.DoEvents();
            InitializeLanguage();
            InitializeSchemes();
            InitializePreDef();
            InitializePortability();
            InitializePersonalization();
            System.Windows.Forms.Application.DoEvents();
            InitializeHash();
            System.Windows.Forms.Application.DoEvents();
            LoadSetting();
            fileAppTheme_SelectionChanged(sender, null);
            ApplyTheme();
        }

        private void fileTabOptions_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSetting();
        }

        private void PART_SET_Click(object sender, RoutedEventArgs e)
        {
            mainTab.SelectedIndex = 0;
            fileTab.SelectedIndex = 0;
        }
        void diffViewSum_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        void hashViewSum_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
