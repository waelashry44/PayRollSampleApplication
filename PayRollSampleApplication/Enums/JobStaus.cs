using System.ComponentModel;

namespace PayRollSampleApplication.Enums
{
    public enum JobStatus
    {
        [Description("started")]
        Started = 1,
        [Description("not yet started")]
        NotYetStarted= 2,
        [Description("not working")] 
        NotWorking= 3
    }
}
