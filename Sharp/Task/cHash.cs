using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace UFSJ.Sharp.Task
{
    static class cHash
    {
        public static string Filename
        {
            get
            {
                return m_Filename;
            }
            set
            {
                m_Filename = value;
                RemoveAllSign();
            }
        }
        static void RemoveAllSign()
        {
            crc32s = "";
            md5s = "";
            sha1s = "";
            sha256s = "";
            sha384s = "";
            sha512s = "";
            filebyte = null;
        }

        public static string OutputPath = "";
        public static System.Windows.Controls.ProgressBar PB;
        static byte[] filebyte;
        static byte[] hash;
        public static string crc32s;
        public static string md5s;
        public static string sha1s;
        public static string sha256s;
        public static string sha384s;
        public static string sha512s;
        public static bool gcrc32s = true;
        public static bool gmd5s = true;
        public static bool gsha1s = false;
        public static bool gsha256s = false;
        public static bool gsha384s = false;
        public static bool gsha512s = false;
        static StringBuilder buff = new StringBuilder();
        public static bool gSHAAlgol = false;
        private static string m_Filename;

        static void GetSHA1()
        {
            UpdateProgress(-1, "Processing", "Generating SHA1", 0);
            using (var SHA = SHA1.Create())
            {
                hash = SHA.ComputeHash(filebyte);
            }
            UpdateProgress(-2, "Processing", "Converting SHA1", 50);
            buff = new StringBuilder();
            foreach (byte hashByte in hash)
            {
                buff.Append(String.Format("{0:X2}", hashByte));
            }
            UpdateProgress(-3, "Processing", "Finishing SHA1", 100);
            sha1s = buff.ToString();
        }

        static void GetSHA2()
        {
            UpdateProgress(-1, "Processing", "Generating SHA256", 0);
            using (var SHA = SHA256.Create())
            {
                hash = (SHA.ComputeHash(filebyte));
            }
            UpdateProgress(-2, "Processing", "Converting SHA256", 50);
            buff = new StringBuilder();
            foreach (byte hashByte in hash)
            {
                buff.Append(String.Format("{0:X2}", hashByte));
            }
            UpdateProgress(-2, "Processing", "Finishing SHA256", 100);
            sha256s = buff.ToString();
        }

        static void GetSHA3()
        {
            UpdateProgress(-1, "Processing", "Generating SHA384", 0);
            using (var SHA = SHA384.Create())
            {
                hash = (SHA.ComputeHash(filebyte));
            }
            UpdateProgress(-2, "Processing", "Converting SHA384", 0);
            buff = new StringBuilder();
            foreach (byte hashByte in hash)
            {
                buff.Append(String.Format("{0:X2}", hashByte));
            }
            UpdateProgress(-3, "Processing", "Finishing SHA384", 0);
            sha384s = buff.ToString();
        }

        static void GetSHA4()
        {
            UpdateProgress(-1, "Processing", "Generating SHA512", 0);
            using (var SHA = SHA512.Create())
            {
                hash = (SHA.ComputeHash(filebyte));
            }
            UpdateProgress(-2, "Processing", "Converting SHA512", 50);
            buff = new StringBuilder();
            foreach (byte hashByte in hash)
            {
                buff.Append(String.Format("{0:X1}", hashByte));
            }
            UpdateProgress(-3, "Processing", "Finishing SHA512", 100);
            sha512s = buff.ToString();
        }

        static void GetMD5()
        {
            UpdateProgress(-1, "Processing", "Generating MD5", 0);
            using (var MD = MD5.Create())
            {
                hash = (MD.ComputeHash(filebyte));
            }

            UpdateProgress(-2, "Processing", "Converting MD5", 50);
            buff = new StringBuilder();
            foreach (byte hashByte in hash)
            {
                buff.Append(String.Format("{0:X2}", hashByte));
            }

            UpdateProgress(-3, "Processing", "Finishing MD5", 100);
            md5s = buff.ToString();
        }

        internal static string GetMD5(string p)
        {
            using (var MD = MD5.Create())
            {
                hash = MD.ComputeHash(File.ReadAllBytes(p));
            }
            buff = new StringBuilder();
            foreach (byte hashByte in hash)
            {
                buff.Append(String.Format("{0:X2}", hashByte));
            }
            return buff.ToString();
        }

        private static void GetCRC32()
        {
            UpdateProgress(-2, "Generating CRC32");
            var c = new Hash.CRC32();
            var ms = new MemoryStream(filebyte);
            var crc = c.GetCrc32(ms);
            crc32s = String.Format("{0:X8}", crc);
            ms.Close();
        }


        public static void Calculate()
        {
            if (File.Exists(Filename))
            {

                if (filebyte == null)
                {
                    filebyte = new byte[0];
                    var ElapsedB = 0;
                    var TotalB = Shared.FileSize(Filename);
                    var Buffer = (int)(TotalB / 100);
                    PB.Maximum = TotalB;
                    var RemainingB = TotalB;
                    try
                    {
                        using (var mmf = MemoryMappedFile.CreateFromFile(Filename, FileMode.Open, "HashStream"))
                        {
                            do
                            {
                                var fs = filebyte.Length;
                                filebyte = new byte[fs + Buffer];
                                using (var st = mmf.CreateViewStream(ElapsedB, Buffer))
                                {
                                    st.Read(filebyte, fs, Buffer);
                                }
                                RemainingB -= Buffer;
                                if (RemainingB < Buffer) Buffer = (int)RemainingB;
                                ElapsedB += Buffer;
                                UpdateProgress(ElapsedB, "Loading Files");
                            } while (RemainingB > 0);
                        }
                    }
                    catch (Exception)
                    {
                        return;
                    }


                }
                if (filebyte != null)
                {

                    PB.Maximum = 6;

                    if (gmd5s && String.IsNullOrEmpty(md5s))
                        GetMD5();
                    if (gcrc32s && String.IsNullOrEmpty(crc32s)) GetCRC32();


                    if (gSHAAlgol)
                    {
                        if (gsha1s && String.IsNullOrEmpty(sha1s)) GetSHA1();
                        if (gsha256s && String.IsNullOrEmpty(sha256s)) GetSHA2();
                        if (gsha384s && String.IsNullOrEmpty(sha384s)) GetSHA3();
                        if (gsha512s && String.IsNullOrEmpty(sha512s)) GetSHA4();
                    }

                    if (!String.IsNullOrEmpty(OutputPath))
                    {
                        var Strs = "UFSJ Generated Checksum" + "\r\n";
                        Strs += "filename :" + Filename + "\r\n";
                        if (gmd5s)
                        {
                            Strs += "[MD5]" + "\r\n";
                            Strs += md5s + "\r\n";
                        }
                        if (gcrc32s)
                        {
                            Strs += "[CRC32]" + "\r\n";
                            Strs += crc32s + "\r\n";
                        }
                        if (gSHAAlgol)
                        {
                            if (gsha1s)
                            {
                                Strs += "[SHA1]" + "\r\n";
                                Strs += sha1s + "\r\n";
                            }
                            if (gsha256s)
                            {
                                Strs += "[SHA256]" + "\r\n";
                                Strs += sha256s + "\r\n";
                            }
                            if (gsha384s)
                            {
                                Strs += "[SHA384]" + "\r\n";
                                Strs += sha384s + "\r\n";
                            }
                            if (gsha512s)
                            {
                                Strs += "[SHA512]" + "\r\n";
                                Strs += sha512s + "\r\n";
                            }
                        }
                        File.WriteAllText(OutputPath, Strs);
                    }
                }
                PB.Maximum = 100;
                UpdateProgress(100, "Calculating Completed", "", 0);
                Thread.Sleep(100);
                UpdateProgress(0, "Ready", "", 0);
            }
            else
            {
            }

        }

        static void UpdateProgress(double mainprogress, string status = "", string childstatus = "", double childprogress = 0, double elapsed = 0, double remaining = 0, long size = 0)
        {
            Shared.UpdateProgress(PB, mainprogress, status, childstatus, childprogress, elapsed, remaining, size);
        }


    }


}
