using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Managment2.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public decimal PriceRoom { get; set; }
        public bool FreeOrBusy { get; set; } = false;
        public int NumberOfPeople { get; set; }

        public List<Client> Clients { get; set; }

    }
}
