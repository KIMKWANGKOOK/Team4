using System;

namespace WorkManagementSystem
{
    public class WorkInstruction
    {
        public string CodeName {get; set;}
        public string WorkDetails { get; set; }
        public DateTime Date { get; set; }
        public string Writer { get; set; }
        public string Worker { get; set; }
        public string Priority { get; set; }
        public int Quantity { get; set; }
        public string WorkStatus { get; set; }

    }
}
