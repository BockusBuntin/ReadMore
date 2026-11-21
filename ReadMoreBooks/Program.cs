using Microsoft.EntityFrameworkCore;
using ReadMoreBooks.Data;

using var context = new ApplicationDbContext();

context.Database.EnsureCreated();

Console.WriteLine("ReadMore Books Database");
Console.WriteLine("------------------------");
Console.WriteLine("Database created successfully!");

Console.WriteLine();
Console.WriteLine("Tables:");
Console.WriteLine("- Authors");
Console.WriteLine("- Categories");
Console.WriteLine("- Books");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
