using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancer.Common
{
    public class Person<Tkey> : EntityBase<Tkey>//person'nın getirdiği   veri tipini entitybase classına veriyor.(rüya içinde rüya)
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
