using System;
using System.IO;
using System.Windows;

namespace UFSJ.Sharp
{
    partial class Shared
    {
        internal static class Setting
        {

            public static void Load()
            {
                var local = GetData("UFSJ.S.uscx");
                try
                {
                    using (var i = new BinaryReader(File.OpenRead(local)))
                    {
                        if (i.ReadChar() == 'U')
                        {
                            OnTopMost = i.ReadBoolean(); //OnTopMost
                            SilentProgress = i.ReadBoolean(); //SilentProgress
                            ShowSummary = i.ReadBoolean(); //ShowSummary
                            AssociateExt = i.ReadBoolean(); //AssociateExt
                            StartHide = i.ReadBoolean(); //StartHide
                            ShellMenus = i.ReadBoolean(); //ShellMenus
                            SettingMode = i.ReadInt16(); //SettingMode
                            Theme = i.ReadString(); //ColorScheme
                            Language = i.ReadString(); //Language
                            Formats = i.ReadString(); //Formats
                            Position = new Point(i.ReadInt32(), i.ReadInt32());
                        }
                    }
                }
                catch (Exception)
                {
                    SaveDefault();
                    Load();
                }

            }

            public static void SaveDefault()
            {
                var local = GetData("UFSJ.S.uscx");
                try
                {
                    File.Delete(local);
                    using (var i = new BinaryWriter(File.OpenWrite(local)))
                    {
                        i.Write(true); //OnTopMost
                        i.Write(false); //SilentProgress
                        i.Write(false); //ShowSummary
                        i.Write(true); //AssociateExt
                        i.Write(true); //StartHide
                        i.Write(true); //ShellMenus
                        i.Write(3); //SettingMode
                        i.Write("Blue"); //ColorScheme
                        i.Write("English (United States)"); //Language
                        i.Write("[fn].[ext].[idx]"); //Formats
                        i.Write(100);
                        i.Write(100);
                    }
                }
                catch (IOException)
                {
                    
                }

            }
     
            public static void Save()
            {
                var local = GetData("UFSJ.S.uscx");
                File.Delete(local);
                using (var i = new BinaryWriter(File.OpenWrite(local)))
                {
                    i.Write('U');
                    i.Write(OnTopMost);
                    i.Write(SilentProgress);
                    i.Write(ShowSummary);
                    i.Write(AssociateExt);
                    i.Write(StartHide);
                    i.Write(ShellMenus);
                    i.Write(SettingMode);
                    i.Write(Theme);
                    i.Write(Language);
                    i.Write(Formats);
                    i.Write((int)Position.X);
                    i.Write((int)Position.Y);
                }
            }

            public static Point Position { get; set; }
            public static bool OnTopMost { get; set; }
            public static bool SilentProgress { get; set; }
            public static bool ShowSummary { get; set; }
            public static bool AssociateExt { get; set; }
            public static bool StartHide { get; set; }
            public static bool ShellMenus { get; set; }
            public static short SettingMode { get; set; }
            public static string Theme { get; set; }
            public static string Language { get; set; }
            public static string Formats { get; set; }
        }

    }
}
