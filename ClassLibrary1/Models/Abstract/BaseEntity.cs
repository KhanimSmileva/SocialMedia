using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Configurations.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int LikeCount { get; set; }

    }
}
