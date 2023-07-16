using System.Collections.Generic;

namespace SignalRApi.Models
{
    public class Team
    {
        public Team()
        {
            Users = new List<User>();
        }
        public int TeamID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
