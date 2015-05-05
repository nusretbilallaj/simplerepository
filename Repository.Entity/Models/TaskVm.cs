using System;

namespace Repository.Entity.Models
{
    public class TaskVm
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string BroadDescription { get; set; }
        public int? ApplicationId { get; set; }
        public DateTime? InsertedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public bool? IsComplete { get; set; }
        public virtual ApplicationVm Application { get; set; }
    }
}