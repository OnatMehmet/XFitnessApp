using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Members :BaseEntity
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public MemberDetails MemberDetails { get; set; }

    }
}
