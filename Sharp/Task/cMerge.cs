using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
namespace UFSJ.Sharp.Task
{

    static class cMerge
    {

        public static bool DeleteFilesAfterMerge = false;
        public static string OutputPath = "";

        public static System.Windows.Controls.ProgressBar PB;
        public static string FileName = "";
        static string oMergedFile;
        static void StartTask()
        {
            var s = Stopwatch.StartNew();

            string[] oMergeFiles = null;
            short i = 0;
            var obuffer = new byte[0];
            long oFileSize = 0;
            double oProgress = 0;
            string[] NotFoundFiles = null;

            doPrepareTask(s, ref oMergeFiles, ref oProgress, ref NotFoundFiles);

            using (var oBinaryWriter = new BinaryWriter(new FileStream(oMergedFile, FileMode.CreateNew))) {
                for (i = 0 ; i < oMergeFiles.Length ; i++) {
                    oFileSize = Shared.FileSize(oMergeFiles[i]);
                    using (var oBinaryReader = new BinaryReader(new FileStream(oMergeFiles[i], FileMode.Open))) {
                        UpdateProgress(oProgress, "Proccessing", Shared.FileBaseName(oMergeFiles[i]), 100, s.Elapsed.TotalMilliseconds);
                        //     oBinaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                        obuffer = new byte[oFileSize];
                        oBinaryReader.Read(obuffer, 0, obuffer.Length);
                        var a = BitConverter.ToString(obuffer, 0, 4);
                        if (a == "55-00-43-00") {
                            var _2buff = new byte[obuffer.Length - 4];
                            Array.Copy(obuffer, 4, _2buff, 0, obuffer.Length - 4);
                            Shared.DecompressFile(_2buff, obuffer);
                        }
                        oBinaryWriter.Write(obuffer);
                        oBinaryWriter.Flush();
                    }
                }
            }

            if (DeleteFilesAfterMerge) doDeleteMergedFiles(oMergeFiles);


            PB.Maximum = 100;
            UpdateProgress(100, "Joinning Completed", "Completed", 100, s.Elapsed.TotalMilliseconds);
            Thread.Sleep(100);
            UpdateProgress(0, "Ready", "", 100, s.Elapsed.TotalMilliseconds);

        }

        static void doPrepareTask(Stopwatch s, ref string[] oMergeFiles, ref double oProgress, ref string[] NotFoundFiles)
        {

            PB.Maximum = 100;
            UpdateProgress(-1, "Preparing everything", "Checking File", 100, s.Elapsed.TotalMilliseconds);
            oMergeFiles = Shared.getMergeFiles(FileName, out NotFoundFiles);
            if (NotFoundFiles != null && NotFoundFiles.Length > 0) {
#if !RELEASE
                Shared.MSGBOX(String.Format("{0} files missing, there are \r\n {1}", NotFoundFiles.Length, String.Join("\r\n", NotFoundFiles)),Application.Current.MainWindow);
#endif
            }

            if (oMergeFiles == null) throw new FileNotFoundException("There are not merging files found in " + Directory.GetParent(FileName).FullName, new Exception());
            oProgress = 100 / (double)(oMergeFiles.Length - 1);
        }

        static void doDeleteMergedFiles(string[] oMergeFiles)
        {
            PB.Maximum = oMergeFiles.Length - 1;
            for (int i = oMergeFiles.Length, a = 0 ; i > 0 ; i--, a++) {
                UpdateProgress(a, Shared.FileBaseName(oMergeFiles[a]));
                File.Delete(oMergeFiles[a]);
            }
        }

        internal static void Start()
        {
            if (OutputPath == "") OutputPath = FileName;
            var op = Directory.GetParent(OutputPath).FullName;
            oMergedFile = OutputPath;
            if (Directory.Exists(op))
                if (File.Exists(oMergedFile)) File.Delete(oMergedFile);
                else
                    Directory.CreateDirectory(op);

            // Now, start task.
            //
            StartTask();
        }
        static void UpdateProgress(double mainprogress, string status = "", string childstatus = "", double childprogress = 0, double elapsed = 0, double remaining = 0, long size = 0)
        {
            Shared.UpdateProgress(PB, mainprogress, status, childstatus, childprogress, elapsed, remaining, size);
        }

    }

}
