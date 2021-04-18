using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Models
{
    public class Users
    {
        [Key]
        public string userId { get; set; }
        public string userName { get; set; }
        public string userLastName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public int userType { get; set; }
    }
}
