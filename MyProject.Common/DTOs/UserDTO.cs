using MyProject.Common.EnumsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public HMOEnumDTO HMO { get; set; }
        public string Parent_1_tz { get; set; }
        public string Parent_2_tz { get; set; }


    }
}
