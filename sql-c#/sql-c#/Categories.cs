using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_c_
{
    internal class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public List<Books> Books { get; set;}
        public Categories(string name)
        {

            Name = name;
        }
    }
}
