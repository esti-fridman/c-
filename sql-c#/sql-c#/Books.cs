using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_c_
{
    internal class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int PublishedYear { get; set; }
        public int CategoryId { get; set; }
        public Books(string title, decimal price, int publishedYear, int categoryId)
        {

            Title = title;
            PublishedYear = publishedYear;
            Price = price;
            CategoryId = categoryId;
        }
    }
}
