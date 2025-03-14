﻿using ClassLibrary1.Configurations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Configurations.Cocrete
{
    public class Post : BaseEntity
    {
        public ICollection<Comment>? Comments { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
