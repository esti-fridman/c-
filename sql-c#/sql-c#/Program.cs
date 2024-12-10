// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using sql_c_;

//Console.WriteLine("Hello, World!");
//add
//using (var context=new DbConnectionManagemen())
//{
//    Books Books = new Books("ruti!!!!!", 12, 1900, 22);
//    Categories category=new Categories("Very Boring");
//    context.Add(Books);
//    context.Add(category);
//    context.SaveChanges();
//    Console.WriteLine("wow");
//}
//read
//using (var context = new DbConnectionManagemen())
//{
//    var Categories = context.Categories.Include(c => c.Books).ToList();
//    foreach (var category in Categories)
//    {
//        Console.WriteLine($",Categoryname: {category.Name}");
//        foreach (var book in category.Books)
//        {
//            Console.WriteLine($"Idbooks: {book.Id},nameBook: {book.Title} ");

//        }
//    }
//}



    static async Task main()
{
    Console.WriteLine("befor delay");
    Task deleyTask = Task.Delay(10000);

    using (var context = new DbConnectionManagemen())
    {
        var categorys = context.Categories.ToList();
        var book = context.Books.ToList();

        foreach (var c in categorys)
        {
            c.Books = book.Where(s => s.CategoryId == c.Id).ToList();
        }

        foreach (var c in categorys)
        {

            Console.WriteLine(" name: {0} ", c.Name);
            Console.WriteLine("-------");
            Console.WriteLine("-------");
            Console.WriteLine("-------");
            foreach (var s in c.Books)
            {
                Console.WriteLine(s.Title);
            }
        }
    }
    await deleyTask;
    Console.WriteLine("after delay");

}








