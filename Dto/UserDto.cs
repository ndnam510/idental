using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace idental
{
    class UserDto
    {
        public Int64 UserID { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string PhotoLink { get; set; }
        public string OtherName { get; set; }
        public string UserType { get; set; }
        public Int64 ZipCodeID { get; set; }
    }
}
