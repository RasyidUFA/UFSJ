using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UFSJ.Sharp
{
    partial class Shared
    {

        /// <summary>
        /// Enables extraction of icons for any file type from
        /// the Shell.
        /// </summary>
        internal class FileIcon
        {

            #region UnmanagedCode
            private const int MAX_PATH = 260;

            [StructLayout(LayoutKind.Sequential)]
            private struct SHFILEINFO
            {
                public IntPtr hIcon;
                public int iIcon;
                public int dwAttributes;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
                public string szDisplayName;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
                public string szTypeName;
            }

            [DllImport("shell32")]
            private static extern int SHGetFileInfo(
                string pszPath,
                int dwFileAttributes,
                ref SHFILEINFO psfi,
                uint cbFileInfo,
                uint uFlags);

            [DllImport("user32.dll")]
            private static extern int DestroyIcon(IntPtr hIcon);

            private const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x100;
            private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x2000;
            private const int FORMAT_MESSAGE_FROM_HMODULE = 0x800;
            private const int FORMAT_MESSAGE_FROM_STRING = 0x400;
            private const int FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;
            private const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x200;
            private const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0xFF;
            [DllImport("kernel32")]
            private extern static int FormatMessage(
                int dwFlags,
                IntPtr lpSource,
                int dwMessageId,
                int dwLanguageId,
                string lpBuffer,
                uint nSize,
                int argumentsLong);

            [DllImport("kernel32")]
            private extern static int GetLastError();
            #endregion

            #region Member Variables
            private string displayName;
            private string typeName;
            private Icon fileIcon;
            #endregion

            #region Enumerations
            [Flags]

            public enum SHGetFileInfoConstants : int
            {
                SHGFI_ICON = 0x100,                // get icon 
                SHGFI_DISPLAYNAME = 0x200,         // get display name 
                SHGFI_TYPENAME = 0x400,            // get type name 
                SHGFI_ATTRIBUTES = 0x800,          // get attributes 
                SHGFI_ICONLOCATION = 0x1000,       // get icon location 
                SHGFI_EXETYPE = 0x2000,            // return exe type 
                SHGFI_SYSICONINDEX = 0x4000,       // get system icon index 
                SHGFI_LINKOVERLAY = 0x8000,        // put a link overlay on icon 
                SHGFI_SELECTED = 0x10000,          // show icon in selected state 
                SHGFI_ATTR_SPECIFIED = 0x20000,    // get only specified attributes 
                SHGFI_LARGEICON = 0x0,             // get large icon 
                SHGFI_SMALLICON = 0x1,             // get small icon 
                SHGFI_OPENICON = 0x2,              // get open icon 
                SHGFI_SHELLICONSIZE = 0x4,         // get shell size icon 
                //SHGFI_PIDL = 0x8,                  // pszPath is a pidl 
                SHGFI_USEFILEATTRIBUTES = 0x10,     // use passed dwFileAttribute 
                SHGFI_ADDOVERLAYS = 0x000000020,     // apply the appropriate overlays
                SHGFI_OVERLAYINDEX = 0x000000040     // Get the index of the overlay
            }
            #endregion

            #region Implementation
            /// <summary>
            /// Gets/sets the flags used to extract the icon
            /// </summary>
            public FileIcon.SHGetFileInfoConstants Flags
            {
                get;
                set;
            }

            /// <summary>
            /// Gets/sets the filename to get the icon for
            /// </summary>
            public string FileName
            {
                get;
                set;
            }

            /// <summary>
            /// Gets the icon for the chosen file
            /// </summary>
            public Icon ShellIcon
            {
                get
                {
                    return fileIcon;
                }
            }

            /// <summary>
            /// Gets the display name for the selected file
            /// if the SHGFI_DISPLAYNAME flag was set.
            /// </summary>
            public string DisplayName
            {
                get
                {
                    return displayName;
                }
            }

            /// <summary>
            /// Gets the type name for the selected file
            /// if the SHGFI_TYPENAME flag was set.
            /// </summary>
            public string TypeName
            {
                get
                {
                    return typeName;
                }
            }

            /// <summary>
            ///  Gets the information for the specified 
            ///  file name and flags.
            /// </summary>
            public void GetInfo()
            {
                fileIcon = null;
                typeName = "";
                displayName = "";

                var shfi = new SHFILEINFO();
                uint shfiSize = (uint)Marshal.SizeOf(shfi.GetType());

                int ret = SHGetFileInfo(
                    this.FileName, 0, ref shfi, shfiSize, (uint)(Flags));
                if (ret != 0)
                {
                    if (shfi.hIcon != IntPtr.Zero)
                    {
                        fileIcon = System.Drawing.Icon.FromHandle(shfi.hIcon);
                        // Now owned by the GDI+ object
                        //DestroyIcon(shfi.hIcon);
                    }
                    typeName = shfi.szTypeName;
                    displayName = shfi.szDisplayName;
                }
                else
                {

                    int err = GetLastError();
                    Console.WriteLine("Error {0}", err);
                    string txtS = new string('\0', 256);
                    int len = FormatMessage(
                        FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
                        IntPtr.Zero, err, 0, txtS, 256, 0);
                    Console.WriteLine("Len {0} text {1}", len, txtS);

                    // throw exception

                }
            }

            /// <summary>
            /// Constructs a new, default instance of the FileIcon
            /// class.  Specify the filename and call GetInfo()
            /// to retrieve an icon.
            /// </summary>
            public FileIcon()
            {
                Flags = SHGetFileInfoConstants.SHGFI_ICON |
                    SHGetFileInfoConstants.SHGFI_DISPLAYNAME |
                    SHGetFileInfoConstants.SHGFI_TYPENAME |
                    SHGetFileInfoConstants.SHGFI_ATTRIBUTES |
                    SHGetFileInfoConstants.SHGFI_EXETYPE;
            }
            /// <summary>
            /// Constructs a new instance of the FileIcon class
            /// and retrieves the icon, display name and type name
            /// for the specified file.		
            /// </summary>
            /// <param name="fileName">The filename to get the icon, 
            /// display name and type name for</param>
            public FileIcon(string fileName)
                : this()
            {
                this.FileName = fileName;
                GetInfo();
            }
            /// <summary>
            /// Constructs a new instance of the FileIcon class
            /// and retrieves the information specified in the 
            /// flags.
            /// </summary>
            /// <param name="fileName">The filename to get information
            /// for</param>
            /// <param name="flags">The flags to use when extracting the
            /// icon and other shell information.</param>
            public FileIcon(string fileName, FileIcon.SHGetFileInfoConstants flags)
            {
                this.FileName = fileName;
                this.Flags = flags;
                GetInfo();
            }

            #endregion
        }
        /// <summary>
        /// 
        /// clsMyFileType.vb
        /// rev 2013-01-22
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// Used to create and remove custom file types.
        /// __________
        /// 
        /// When setting the FileIcon property you can reference the executable by using the
        /// token of "%APP%" within the string.  This will translate into the system's 
        /// Application.ExecutablePath value.
        /// __________
        /// 
        /// In the form load event or in your sub main() you will need to add something
        /// like this to handle the custom file's open command.  The command line arguments
        /// is type "Collections.ObjectModel.ReadOnlyCollection(Of String)".  You will want
        /// to process these something like this:
        ///  
        ///     If My.Application.CommandLineArgs.Count > 0 Then
        ///        For Each s As String In My.Application.CommandLineArgs
        ///          :
        ///          :
        ///        Next
        ///     End If
        /// 
        /// For single instance applications you will need to add the StartupNextInstance
        /// event within the ApplicationEvents file (Project | Properties... | Application |
        /// View Application Events) to handle the command line values.
        /// 
        /// As above, the file(s) will be passed via the command line, using e.CommandLine,
        /// which is also a of type "Collections.ObjectModel.ReadOnlyCollection(Of String)".
        /// You will want to process these something like this:
        /// 
        ///        For Each s As String In e.CommandLine
        ///          :
        ///          :
        ///        Next
        /// __________
        /// 
        /// To include icons within the EXE that VB.NET creates, you need to create the RES
        /// file using something like ResEdit (http://www.resedit.net/) and then manually edit
        /// the .vbproj file for the project and add a new PropertyGroup branch for the file
        /// that was created.  In this example, the RES file created was called "icons.res",
        /// so the project file would need this added to it:
        /// 
        ///   <PropertyGroup>
        ///     <Win32Resource>icons.res</Win32Resource>
        ///   </PropertyGroup>
        /// 
        /// This should be common sense, but when you edit this file you cannot have the
        /// project open.  While you can open the RES file via the Visual Studio editor DO NOT
        /// do this or the resources will not appear properly.
        /// 
        /// The first icon resource in this file MUST be the icon you desire for the 
        /// application and should have the lowest resource number in the file.  The resource
        /// number for the icons start at 0 (application's icon) and increment by one, 
        /// regardless of the resource ID numbers assigned within the RES file.
        /// 
        /// </remarks>
        internal class FileType
        {

            [System.Runtime.InteropServices.DllImport("Shell32.dll", EntryPoint = "SHChangeNotify", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
            private static extern Int32 SHChangeNotify(Int32 wEventID, Int32 uFlags, Int32 dwItem1, Int32 dwItem2);
            #region Properties
            public string Extension { get; set; }

            public string ShortDescription { get; set; }

            public string FileDescription { get; set; }

            private string lFileIcon = "";
            private string m_Cmd;
            public string FileIcon
            {
                get
                {
                    return lFileIcon;
                }
                set
                {
                    lFileIcon = value.Trim().Replace("%APP%", Application.ExecutablePath);
                }
            }
            #endregion

            public FileType(string newExt = "", string newShortDesc = "", string newDesc = "", string newIcon = "")
            {

                // Check to see if there is a new file extension being given
                Extension = CheckSetVal(newExt, Extension);

                // Check to see if there is a new short description being given
                ShortDescription = CheckSetVal(newShortDesc, ShortDescription);

                // Cannot have spaces, so replace them with "." (what you typically see)
                ShortDescription = ShortDescription.Replace(" ", ".");

                // Check to see if there is a new description being given
                FileDescription = CheckSetVal(newDesc, FileDescription);

                // Check to see if there is an icon path being given
                FileIcon = CheckSetVal(newIcon, FileIcon);
            }

            public FileType(string p1, string p2, string p3, string p4, string p5)
                : this(p1, p2, p3, p4)
            {
                newCommand = p5;

            }

            private string CheckSetVal(string newval, string oldval)
            {

                return (newval.Trim().Length > 0) ? newval.Trim() : oldval.Trim();

            }

            public bool CheckForRegistration(string newExt = "", string newShortDesc = "", string newDesc = "", string newIcon = "")
            {
                bool ret = false;

                // Check to see if there is a new file extension being given
                Extension = CheckSetVal(newExt, Extension);

                // Check to see if there is a new short description being given
                ShortDescription = CheckSetVal(newShortDesc, ShortDescription);
                // Cannot have spaces, so replace them with "." (what you typically see)
                ShortDescription = ShortDescription.Replace(" ", ".");

                // Must have a short file description
                if (ShortDescription.Trim().Length < 1) ShortDescription = Extension.Substring(1) + ".File";

                // Check to see if there is a new description being given
                FileDescription = CheckSetVal(newDesc, FileDescription);

                // Check to see if there is an icon path being given
                FileIcon = CheckSetVal(newIcon, FileIcon);

                // Make sure there is a file extension defined
                if (Extension.Trim().Length < 1) return false;

                // We always want a "." to preceed the extension, so add it if the programmer
                // forgot to add one
                AddDotIfForgot();

                // Check to see of the registry classes root (HKEY_CLASSES_ROOT) has the
                // extension.  This is testing is doing a case insensitive search
                ret = Registry.ClassesRoot.GetSubKeyNames().Contains(Extension, StringComparer.OrdinalIgnoreCase);
                return ret;
            }

            void AddDotIfForgot()
            {
                if (Extension.Substring(0, 1) != ".")
                {
                    Extension = "." + Extension;
                }
            }

            public bool RemoveRegistration()
            {
                bool ret = true;
                // Make sure there is a file extension defined
                if (Extension.Trim().Length < 1)
                {
                    return false;
                }
                // We always want a "." to preceed the extension, so add it if the programmer
                // forgot to add one
                AddDotIfForgot();

                // Cannot have spaces, so replace them with "." (what you typically see)
                const string space = " ";
                if (ShortDescription.IndexOf(space) > 0)
                {
                    ShortDescription = ShortDescription.Replace(space, ".");
                }
                // Must have a short file description
                if (ShortDescription.Trim().Length < 1)
                {
                    ShortDescription = Extension.Substring(1) + ".File";
                }
                try
                {
                    Registry.ClassesRoot.DeleteSubKeyTree(Extension);
                    Registry.ClassesRoot.DeleteSubKeyTree(ShortDescription);
                }
                catch
                {
                    ret = false;
                }
                SHChangeNotify(0x8000000, 0x0, 0, 0);
                return ret;
            }

            public bool AddRegistration(bool bRefresh = false)
            {
                RegistryKey reg = null;
                RegistryKey reg2 = null;
                bool ret = true;
                //
                // Make sure there is a file extension defined
                if (Extension.Trim().Length < 1) return false;
                // We always want a "." to preceed the extension, so add it if the programmer
                // forgot to add one
                AddDotIfForgot();

                // Cannot have spaces, so replace them with "." (what you typically see)
                if (ShortDescription.IndexOf(" ", StringComparison.Ordinal) > 0)
                    ShortDescription = ShortDescription.Replace(" ", ".");

                // Must have a short file description
                if (ShortDescription.Trim().Length < 1)
                    ShortDescription = Extension.Substring(1) + ".File";

                // If this is already registered and the registration is not being refreshed,
                // then return FALSE here
                if (CheckForRegistration() && !bRefresh)

                    return false;


                // If we are refreshing the registration remove the existing registrations if
                // any exists
                if (bRefresh)
                {
                    try
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree(Extension);
                        Registry.ClassesRoot.DeleteSubKeyTree(ShortDescription);
                        SHChangeNotify(0x8000000, 0x0, 0, 0);
                    }
                    catch
                    {
                        // Ignore failures (keys probabily don't exist)
                    }
                }
                // Try to create the new file type's registry key
                try
                {
                    reg = Registry.ClassesRoot.CreateSubKey(Extension, RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                catch
                {
                    // Failed, so exit returning FALSE now
                    return false;
                }

                // If the registry variable is nothing then the key creation failed, so
                // return FALSE now
                if (reg == null) return false;
                // Set the defaut value for the file type
                reg.SetValue("", ShortDescription);
                // Try to create the short description section
                try
                {
                    reg = Registry.ClassesRoot.CreateSubKey(ShortDescription, RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                catch
                {
                    // Try to remove the above work
                    Registry.ClassesRoot.DeleteSubKeyTree(Extension);
                    return false;
                }

                // If the registry variable is nothing then the key creation failed, so
                // return FALSE now
                if (reg == null)
                {
                    // Try to remove the above work
                    Registry.ClassesRoot.DeleteSubKeyTree(Extension);
                    SHChangeNotify(0x8000000, 0x0, 0, 0);
                    return false;
                }
                // Create the subkey for the open command
                reg2 = reg.CreateSubKey("shell\\open\\command");
                // If the key was created...
                if (reg2 != null)
                {
                    // ...set the default value
                    reg2.SetValue("", (newCommand != "" ? newCommand : Application.ExecutablePath + (LoadSilent ? " -S" : "") + " \"%1\" "));
                }
                // Add the icon reference
                if (FileIcon.Trim().Length > 0)
                {
                    // Create the default icon key
                    RegistryKey regIcon = reg.CreateSubKey("DefaultIcon");
                    // If the key was created...
                    if (regIcon != null)
                    {
                        // ...set the default value
                        regIcon.SetValue("", FileIcon.Trim());
                    }
                }

                SHChangeNotify(0x8000000, 0x0, 0, 0);
                return ret;
            }

            public string newCommand { get { return m_Cmd; } set { m_Cmd = value.Trim().Replace("%APP%", Application.ExecutablePath); } }
        }
    }
}
