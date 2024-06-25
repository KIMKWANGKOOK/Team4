using System;

namespace WorkManagementSystem
{
    public class WorkInstruction
    {
        public string TaskName { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Writer { get; set; }
        public string Priority { get; set; }
    }
}
