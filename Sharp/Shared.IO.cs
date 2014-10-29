using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace UFSJ.Sharp
{
    partial class Shared
    {
        internal static void EncryptFile(string inputFile, string outputFile, string password)
        {

            try {
                var UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                var fsCrypt = new FileStream(cryptFile, FileMode.Create);

                var AesMngd = new AesManaged();

                var cs = new CryptoStream(fsCrypt,
                    AesMngd.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                using (var fsIn = new FileStream(inputFile, FileMode.Open)) {
                    int data;
                    while ((data = fsIn.ReadByte()) != -1)
                        cs.WriteByte((byte)data);
                }
                cs.Close();
                fsCrypt.Close();
            } catch {
                Shared.MSGBOX(Shared.GetRes("#D.02#","Error"),"Encryption failed!",System.Windows.Application.Current.MainWindow);
            }
        }

        internal static void DecryptFile(string inputFile, string outputFile, string password)
        {

            {
                var UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                var fsCrypt = new FileStream(inputFile, FileMode.Open);

                var RMCrypto = new AesManaged();

                var cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                var fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
        }

        internal static void CompressFile(ICloneable input, object output)
        {
            //LZ4Sharp.LZ4.Compress(input, output); 
            output = (byte[])input.Clone();
        }

        internal static void DecompressFile(ICloneable input, object output)
        {
         //   LZ4Sharp.LZ4.Decompress(input, output);
            output = (byte[])input.Clone();
        }

        //internal static void CompressFile(byte[] input, byte[] output)
        //{
        //    using (var a = new MemoryStream(output))
        //    using (var s = new LZ4.LZ4Stream(a, CompressionMode.Compress, true,1024*1024*8)) {
        //        s.Write(input, 0, input.Length);
        //        s.Flush();
        //        output = a.ToArray();
        //    }

        //}

        //internal static void DecompressFile(byte[] input, byte[] output)
        //{
        //    using (var a = new MemoryStream(input))
        //    using (var s = new LZ4.LZ4Stream(a, CompressionMode.Decompress, true, 1024 * 1024 * 8)) {
        //        s.Read(output, 0, output.Length);
        //        s.Flush();
        //        output = a.ToArray();
        //    }

        //}

        internal static string GetFNWoExt(string value, bool leave = false)
        {
            // Find last available character.
            // ... This is either last index or last index before last period.
            int lastIndex = value.Length - 1;
            for (int i = lastIndex ; i >= 1 ; i--) {
                if (value[i] == '.') {
                    lastIndex = i - 1;
                    break;
                }
            }
            // Find first available character.
            // ... Is either first character or first character after closest /
            // ... or \ character after last index.
            int firstIndex = 0;
            for (int i = lastIndex - 1 ; i >= 0 ; i--) {
                switch (value[i]) {
                    case '/':
                    case '\\': {
                            firstIndex = i + 1;
                            goto End;
                        }
                }
            }
        End:
            // Return substring.
            if (leave) firstIndex = 0;
            return value.Substring(firstIndex, (lastIndex - firstIndex + 1));
        }

        internal static string GetSizeWithLabel(long p1)
        {
            var p2 = Math.Pow(1024, 2);
            var p3 = Math.Pow(1024, 3);
            string ps = null;
            if (p1 <= 1024)
                ps = p1 + " B";
            else if (p1 <= p2)
                ps = Math.Round(p1 / 1024.0, 2) + " KB";
            else if (p1 < p3)
                ps = Math.Round(p1 / p2, 2) + " MB";
            else if (p1 >= p3)
                ps = Math.Round(p1 / p3, 2) + " GB";
            return ps;
        }

        internal static long FileSize(string Filename)
        {
            return new FileInfo(Filename).Length;
        }

        internal static long FreeSpace(string p)
        {
            return new DriveInfo(p).TotalFreeSpace;
        }

        internal static string FileBaseName(string Filename)
        {
            return new FileInfo(Filename).Name;
        }

        internal static string LocalData(string filename = "")
        {
            var local = Path.Combine(Environment.GetEnvironmentVariable("LOCALAPPDATA"), @"UFASoft\UFSJ", filename);
            if (!Directory.Exists(Directory.GetParent(local).FullName)) Directory.CreateDirectory(Directory.GetParent(local).FullName);
            return local;
        }

        internal static string GetData(string name)
        {
            var local = Shared.LocalData(name);
            var local2 = name;
            if (!File.Exists(local) && !File.Exists(local2)) {
                return local;
               // throw new FileNotFoundException(name + " not found in current directory or local data");
            }
            if (File.Exists(local2)) {
                return local2;
            } 
			if (File.Exists(local)) {
				return local;
			}
            return name;
        }   
        internal static void SaveLog()
        {

        }
    }
}
