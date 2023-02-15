using MyProject.Common.EnumsDTO;

namespace MyProject.API.Models
{
    public class UserModel
    {
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
