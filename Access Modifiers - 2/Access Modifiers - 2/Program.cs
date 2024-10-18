using System.Text.RegularExpressions;

namespace Access_Modifiers___2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BookLibrary booklibrary = new BookLibrary("Books", "Authors", true);

			Book book = new Book
			{
				_name = "The Great Gatsby",
				_author = "F.Scott Fitzgerald",
				_isavailable = true
			};

			Book book2 = new Book
			{
				_name = "Moby - Dick",
				_author = "Herman Melville",
				_isavailable = true
			};
			Book book3 = new Book
			{
				_name = "Tender is the nigth",
				_author = "F.Scott Fitzgerald",
				_isavailable = true
			};

			booklibrary.Add(book);
			booklibrary.Add(book2);
			booklibrary.Add(book3);
			booklibrary.RemoveBook("Moby - Dick");
			booklibrary.Show();


			//booklibrary.SearchByAuthor("F.Scott Fitzgerald");
			//booklibrary.ReturnBook("Moby - Dick");



		}





	}
	
}
