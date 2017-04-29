using System.ComponentModel.DataAnnotations;

namespace RubenWepApp.Models
{
    public class ClientAddressItem
    {
        [Key]
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Intersection1 { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateStamp { get; set; }
    }
}