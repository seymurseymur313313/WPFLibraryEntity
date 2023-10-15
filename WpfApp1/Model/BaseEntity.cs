using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreadetDate { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
