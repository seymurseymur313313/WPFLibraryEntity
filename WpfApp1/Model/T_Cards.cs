using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class T_Cards : BaseEntity
    {
   
        public int TeacherID { get; set; }
        public int BookID { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int LibID { get; set; }

    }
}
