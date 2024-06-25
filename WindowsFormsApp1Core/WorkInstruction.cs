using System;

namespace WorkManagementSystem
{
    public class WorkInstruction
    {
        public string CodeName { get; set; }
        public string WorkDetails { get; set; }
        public DateTime Date { get; set; }
        public string Writer { get; set; }
        public string Worker { get; set; }
        public string Priority { get; set; }
        public string Supply { get; set; }

        public string Work_Status { get; set; }

        public int SupplyAmount { get; set; }
    }
}
