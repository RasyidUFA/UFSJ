using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace UFSJ.Sharp.Task
{

    /// <summary>
    /// Class for splitting task.
    /// </summary>
    /// <example>
    /// cSplit.FileName = "C:\TestFile.txt";
    /// cSplit.OutputPath = "C:\TestFiles\";
    /// cSplit.ChunkSize = 1024;
    /// cSplit.PB = new ProgressBar();
    /// cSplit.DeleteFileAfterSplit = false;
    /// cSplit.Start();
    /// </example>
    static class cSplit
    {
        /// <summary>
        /// Setting Field
        /// Delete file after successfuly split.
        /// </summary>
        /// <remarks>may cause dataloss</remarks>
        public static bool DeleteFileAfterSplit = false;
        /// <summary>
        /// Using standard Extension (*.00x) for filename
        /// </summary>
        public static bool UseStandardExt = true;
        /// <summary>
        /// Generate Header for Joinning Task.
        /// </summary>
        public static bool AddHeader = false;
        /// <summary>
        /// Generate Self Unite for split parts.
        /// </summary>
        public static bool GenerateJoiner = true;
        /// <summary>
        /// Encrypt Part with password, used for security.
        /// </summary>
        public static bool EncryptParts = false;
        /// <summary>
        /// Compress Part.
        /// </summary>
        public static bool CompressParts = false;
        /// <summary>
        /// Password Encryption, used for security.
        /// </summary>
        public static string Password = "";

        public static string OutputPath = "";
        public static string FileName = "";
        public static long ChunkSize = 0;
        public static System.Windows.Controls.ProgressBar PB;

        static Stopwatch s;
        static void UpdateProgress(double mainprogress, string status = "", string childstatus = "", double childprogress = 0, double elapsed = 0, double remaining = 0, long size = 0)
        {
            Shared.UpdateProgress(PB, mainprogress, status, childstatus, childprogress, elapsed, remaining, size);
        }
        /// <summary>
        /// Start Splitting task.
        /// </summary>
        public static void Start()
        {
            s = Stopwatch.StartNew();
            if (!(File.Exists(FileName))) throw new Exception("File " + FileName + " doesn't exist");
            long oFileSize = Shared.FileSize(FileName);

            // Progress Updating
            PB.Maximum = 100;
            UpdateProgress(0, "Preparing", "validation", 0);

            if (OutputPath == "") OutputPath = Directory.GetParent(FileName).ToString();
            if (!(Directory.Exists(OutputPath))) Directory.CreateDirectory(OutputPath);
            short oFragments = Convert.ToInt16(Math.Floor(oFileSize / (double)ChunkSize));

            if (oFileSize <= ChunkSize) throw new Exception(FileName + " size(" + oFileSize + ")  is less than the ChunkSize(" + ChunkSize + ")");

            // Progress Updating
            UpdateProgress(0, "Preparing", "Validation complete", 100, s.Elapsed.TotalMilliseconds);

            // Do Split
            doSplit(oFileSize, oFragments);

            //Delete After Split
            if (DeleteFileAfterSplit)
                File.Delete(FileName); UpdateProgress(-1, "Deleting SourceFile", Shared.GetFNWoExt(FileName), 100, s.Elapsed.TotalMilliseconds);
            if (GenerateJoiner) {
                UpdateProgress(-2, "Generating Joinner", Shared.GetFNWoExt(FileName) + ".cmd", 100, s.Elapsed.TotalMilliseconds); DoGenerateJoiner();
            }

            PB.Maximum = 100;
            UpdateProgress(100, "Splitting Completed");
            Thread.Sleep(100);
            UpdateProgress(0, "Ready");
        }

        public static int[] GeneratedPart { get; set; }

        public static bool Increment { get; set; }

        internal static void StartPart()
        {
            SplitParts = true;
            Start();
        }

        private static void doSplit(long oFileSize, short oFragments)
        {
            using (var oBinR = new BinaryReader(File.Open(FileName, FileMode.Open))) {
                // UFSJ Algorithm
                string FileOutput = "";
                long ByteRemains = oFileSize;
                short Idx = 0;
                byte[] _buff;
                long BytesElapsed = 0;
                long BuffSize = ChunkSize;
                PB.Maximum = oFileSize;

                oBinR.BaseStream.Seek(0, SeekOrigin.Begin);
                files = new List<string>();
                while (ByteRemains > 0) {
                    BytesElapsed += BuffSize;
                    ByteRemains -= BuffSize;
                    Idx++;

                    if (SplitParts && !GeneratedPart.Contains(Idx)) continue;

                    FileOutput = (OutputPath + "\\") + Shared.FileBaseName(FileName) + "." + Idx.ToString("000");
                    UpdateProgress(BytesElapsed, "Splitting file", FileOutput, 100, s.Elapsed.TotalMilliseconds, 0, BuffSize);
                    // Read Data Buffer from Source file
                    _buff = new byte[BuffSize];
                    oBinR.Read(_buff, 0, (int)BuffSize);
                    if (CompressParts) {
                        var _2buff = (byte[])_buff.Clone();
                        Shared.CompressFile(_2buff, _buff);
                        _2buff = new byte[_buff.Length + 4];
                        
                        var b = BitConverter.GetBytes('U');
                        b.CopyTo(_2buff, 0);
                        var nlen =  b.Length;
                        b = BitConverter.GetBytes('C');
                        b.CopyTo(_2buff, b.Length);
                        nlen += b.Length;
                        _buff.CopyTo(_2buff, nlen);
                        _buff = _2buff;

                    }
                    // Write Data Buffer To Split Part
                    WriteToPart(FileOutput, _buff);
                    files.Add(FileOutput);

                    if (ByteRemains < BuffSize) BuffSize = Convert.ToInt32(ByteRemains);
                    UpdateProgress(BytesElapsed, "Splitting file", Shared.FileBaseName(FileName) + "." + Idx.ToString("000"), 100, s.Elapsed.TotalMilliseconds, 0, BuffSize);

                }
            }
        }

        private static void WriteToPart(string FileOutput, byte[] _buff)
        {
            if (File.Exists(FileOutput)) File.Delete(FileOutput);
            using (var oBinWriter = new BinaryWriter(File.Open(FileOutput, FileMode.Create))) {
                oBinWriter.Write(_buff);
                oBinWriter.Flush();
                oBinWriter.Close();
            }
        }

        static List<string> files;

        /// <summary>
        /// Generate Joinner
        /// </summary>
        static void DoGenerateJoiner()
        {
            var basepath = OutputPath;
            var filenames = Shared.GetFNWoExt(FileName);
            using (var i = new StreamWriter(basepath + "\\UFSJ " + Shared.GetFNWoExt(FileName) + ".cmd", false, Encoding.Default)) {
                var b = new BatchM(false, 50, 25);
                var version = System.Windows.Forms.Application.ProductVersion.ToString();
                b.Title("UFSJ " + version);
                var now = DateTime.Now;
                b.Comment(String.Format("Universal File Splitter ^& Joinner : Generated On {0} {1}", now.ToShortDateString(), now.ToShortTimeString()));
                b.Clear();
                b.Label("Main");
                b.Clear();
                b.WriteLn("echo ┌─────────────────────────────────────────────────\r\n" + "echo ^| UFSJ Std Self-Joiner \r\n" + "echo ^| © UFASoft Technology 2014 \r\n" + "echo ^| Visit : http://ufsj.weebly.com \r\n" + "echo ^| This Joiner will working with :\r\n" + "echo ^| Target File : " + filenames + " \r\n" + "echo ^| Part Needed :" + files.Count + "\r\n" + "echo ^| Your Task:\r\n" + "echo ^| backup your target file(if exist)\r\n" + "echo ^| check existance of Part \r\n" + "echo ^| check ifyou have an Acces to Disk\r\n" + "echo └─────────────────────────────────────────────────\r\n" + "echo If it's okay, you can continue:");
                b.Confirmation("Continue?");
                b.Pause();
                b.Label("Start");
                b.Echo(String.Format("Processing {0} \t {1} ^%%", new FileInfo(files[0]).Name, Math.Floor((double)(100 / files.Count)) * (1)));
                b.Task("copy", " \"", files[0], "\" ", "\"", "temp1.utmp", "\" ", ">> ", "UFSJ.log");
                b.Comment("Start Joinning Bytes");
                for (int a = 1 ; a < files.Count ; a++) {
                    //  b.Clear();
                    b.Echo(String.Format("Processing {0} \t {1} ^%%", new FileInfo(files[a]).Name, Math.Floor((double)(100 / files.Count)) * (a + 1)));
                    b.Task("copy", " \"", basepath +
                        "\\temp" + a + ".utmp", "\" ", "+ ", "\"", files[a], "\" \"", basepath + "\\temp" + (a + 1) + ".utmp", "\" ", ">> ", "UFSJ.log");
                    b.Task("del", " \"", basepath + "\\temp" + a + ".utmp", "\"", ">> ", "UFSJ.log");
                }
                b.Echo(String.Format("Processing {0} \t {1} ^%%", filenames, 100));
                b.IfED(FileName);
                b.Task("ren", " \"", "temp" + files.Count + ".utmp", "\" ", " ", "\"", new FileInfo(FileName).Name, "\" ", ">> ", "UFSJ.log");
                b.Echo("Joinning Completed!");
                b.WriteLn("");
                b.Pause();
                // End
                b.Label("Exit");
                i.Write(b.Result);
                i.Flush();
            }
        }


        public static bool SplitParts { get; set; }
    }
}
