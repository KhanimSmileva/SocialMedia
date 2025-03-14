﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Configurations.Cocrete
{
    public class User
    {
        public int Id { get; set; }
        public int UserDetailsId { get; set; }
        public UserDetails? UserDetails { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
