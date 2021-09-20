using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods
{
    public class UserStub
    {
        public List<string> Users { get; set; }
        public UserStub()
        {
            Users = new List<string>() { "Programacion", "Cesar", "Yosselin","Jennifer", "Juan","Mateo","Oscar","Simon"};
        }
    }
}
