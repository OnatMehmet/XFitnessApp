using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class MemberDetails
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }

        public int MemberId { get; set; }

        public Members Members { get; set; }

    }
}
