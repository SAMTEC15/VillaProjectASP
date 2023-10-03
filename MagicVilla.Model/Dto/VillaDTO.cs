using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVilla.Model.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
