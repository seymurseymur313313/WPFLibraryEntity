using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Context
{
    public class LibraryDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0128-16;Initial Catalog=Libraryyyyyy;User ID=admin;Password=********;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public List<Authors> Author { get; set; }
        public List<Books> Book { get; set; }
        public List<Departments> Department { get; set; }
        public List<Faculties> Facultie { get; set; }
        public List<Groups> Group { get; set; }
        public List<Libs> Lib { get; set; }
        public List<Press> Pres { get; set; }
        public List<Students> Student { get; set; }
        public List<T_Cards> T_Card { get; set; }
        public List<Teacher> Teachers { get; set; } 
        public List<Themes> Themess { get; set; }



    }







}
