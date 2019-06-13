using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MBSA_Dev_Test.Models
{
    public class Project
{
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string ProjectName { get; set; }

        [Required]
        [StringLength(500)]
        public string Image { get; set; }

        [Required]
        public string Description { get; set; }

        public bool Deleted { get; set; }
    }
}
