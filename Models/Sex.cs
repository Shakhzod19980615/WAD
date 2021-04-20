using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Managment2.Models
{
    public class Sex
    {
        [Key]
        public int Id { get; set; }
        public string Gender { get; set; }

        public List<Client> Clients { get; set; }


    }
}
