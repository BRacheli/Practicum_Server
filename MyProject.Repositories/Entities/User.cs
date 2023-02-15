using MyProject.Repositories.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required,MaxLength(9),MinLength(9)]
        public string Tz { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Gender { get; set; }//מין
        // public string HMO { get; set; }//קופת חולים
        [Required]
        public HMOEnum HMO { get; set; }
        [MaxLength(9), MinLength(9)]
        public string Parent_1_tz { get; set; }
        [MaxLength(9), MinLength(9)]
        public string Parent_2_tz { get; set; }
    }
}
