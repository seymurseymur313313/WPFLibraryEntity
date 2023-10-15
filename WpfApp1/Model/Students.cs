using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Students : BaseEntity
    {
        public string firstName { get; set; }
        public string LastName { get; set; }
        public int GroupID { get; set; }
        public int term { get; set; }
    }
}
