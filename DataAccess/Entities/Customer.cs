using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        [Range(0, 110)]
        public int Age { get; set; }

        [Required]
        public string Postcode { get; set; }

        [Range(0, 2.50)]
        public Double Height { get; set; }
    }
}
