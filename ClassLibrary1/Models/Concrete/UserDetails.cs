using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Configurations.Cocrete
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Role? Roles { get; set; }

    }
}
