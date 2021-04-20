using System;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Managment2.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Passport { get; set; }
        public string Telephone { get; set; }
        public DateTime DataToday { get; set; } = DateTime.Now;
        public DateTime DataEnd { get; set; }
        
        public int SexId { get; set; }
        public Sex Sex { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
