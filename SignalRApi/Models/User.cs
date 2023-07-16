namespace SignalRApi.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }

        public int TeamID { get; set; }
        public virtual Team Team { get; set; }
    }
}
