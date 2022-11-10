var author = new Author("Rahimbek Azizbekov","Rahimjon23@bk.ru",'M');
System.Console.WriteLine(author.ToString());
var book = new Book("Rahimbek Azizbekov","Rahimjon23@bk.ru",'M',"Harry Hower",author,7.68,9);
book.SetPrice(5.50);
System.Console.WriteLine(book.GetPrice());
System.Console.WriteLine(book.ToString());