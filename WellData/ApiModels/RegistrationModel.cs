using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellData.ApiModels
{
    public class RegistrationModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
