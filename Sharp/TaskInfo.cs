
namespace UFSJ.Sharp
{
    class TaskInformation
    {
        public string MainStatus;
        public double MainProgress;

        public string ChildStatus;
        public long ChildSize;
        public double ChildProgress;
        public double Elapsed;
        public double Remaining;

        public TaskInformation(string Status, string childStatus)
        {
            MainStatus = Status;
            ChildStatus = childStatus;

        }
        public TaskInformation(string status, string childstatus, double mainprogress, double childprogress)
            : this(status, childstatus)
        {
            MainProgress = mainprogress;
            ChildProgress = childprogress;
        }
        public TaskInformation(string status, string childstatus, double mainprogress, double childprogress, double elapsed, double remaining)
            : this(status, childstatus, mainprogress, childprogress)
        {
            Elapsed = elapsed;
            Remaining = remaining;
        }
        public TaskInformation(string status, string childstatus, double mainprogress, double childprogress, double elapsed, double remaining, long size)
            : this(status, childstatus, mainprogress, childprogress, elapsed, remaining)
        {
            ChildSize = size;
        }
    }

}
