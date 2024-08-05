using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkS2.Models
{
    internal class Depatment
    {
        [Key]
        [Range(1,200)]
        [Column("Id")]
        public int DepId { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(40,MinimumLength =10)]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Description { get; set; }
        [NotMapped]
        public string Type { get; set; }
    }
}
