using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.DTO.UserDTO
{
    public class ModifyUserDTO
    {
        public string newUserName { get; set; }
        public string newUserLastName { get; set; }
        public string newUserEmail { get; set; }
        public string newUserPassword { get; set; }
        public int? newUserType { get; set; }
    }
}
