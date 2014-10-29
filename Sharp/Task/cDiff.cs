using System.IO;

namespace UFSJ.Sharp.Task
{
    static class cDiff
    {
        public static string Filename;
        public static string DiffFilename;
        public static System.Windows.Controls.ProgressBar PB;

        static void UpdateProgress(double mainprogress, string status = "", string childstatus = "", double childprogress = 0, double elapsed = 0, double remaining = 0, long size = 0)
        {
            Shared.UpdateProgress(PB, mainprogress, status, childstatus, childprogress, elapsed, remaining, size);
        }

        internal static string Compare()
		{
			if (Filename == DiffFilename)
				return "File are identic, choose different one";

			var f1 = new FileInfo(Filename);
			var f2 = new FileInfo(DiffFilename);
			if (f1.Length == f2.Length) { // File are same
				var a = cHash.GetMD5(f1.FullName);
				var b = cHash.GetMD5(f2.FullName);
				if (a != b) {
					return "File Hash invalid \n" + a + "\n" + b;
				}
				return "file identic \nMD5 (Source) :" + a + "\nMD5 (Second):" + b;
			}
			return "file different length";

            
			//using (var d = MemoryMappedFile.CreateFromFile(DiffFilename))
			//using (var e = MemoryMappedFile.CreateFromFile(Filename))
			//{

			//}
		}
    }
}
