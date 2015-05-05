using System.Collections.Generic;

namespace Repository.Entity.Models
{
    public class ApplicationVm
    {
        public ApplicationVm()
        {
            Tasks = new List<TaskVm>();
        }

        public int ApplicationId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TaskVm> Tasks { get; set; }
    }
}