using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_oop1
{
    internal class HocSinh
    {
        //Auto-Implemented Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // phương thức Tótring 
        public override string ToString()
        {
            return this.Name+"\t" + this.Email +"\t" +this.Phone ;
        }
    }
}
