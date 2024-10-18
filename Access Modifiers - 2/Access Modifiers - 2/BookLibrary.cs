using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers___2
{
	internal class BookLibrary
	{
		private string _name;
		private string _author;
		private bool _isavailable;



		public Book[] books = new Book[0];

		public Book[] Books
		{
			get
			{
				return books;
			}
			set
			{
				books = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}


		}
		public string Author
		{
			get
			{
				return _author;
			}
			set
			{
				_author = value;
			}


		}
		public bool IsAvailable
		{
			get
			{
				return _isavailable;
			}
			set
			{
				_isavailable = value;
			}


		}

		public BookLibrary(string name, string author, bool isavailable)
		{
			Name = name;
			Author = author;
			IsAvailable = isavailable;


		}



		public void Add(Book book)
		{
			Array.Resize(ref books, Books.Length + 1);
			Books[Books.Length - 1] = book;
		}


		public void Show()
		{
			for (int i = 0; i < books.Length; i++)
			{
				Console.WriteLine($"Book Name : {books[i]._name}\nAuthor Name : {books[i]._author}");
			}
		}


		public void RemoveBook(string name)
		{
			Book[] newArr = new Book[books.Length - 1];
			int j = 0;
			for (int i = 0; i < books.Length; i++)
			{
				if (books[i]._name != name)
				{
					newArr[j] = books[i];
					j++;
				}

			}
			books = newArr;
		}



		public Book BorrowBook(string name)
		{
			for (int i = 0; i < Books.Length; i++)
			{
				if (books[i]._name == name)
				{
					if (books[i]._isavailable)
					{
						books[i]._isavailable = false;
						Console.WriteLine($"{books[i]._name} is available");
						return books[i];
					}
					else
					{
						Console.WriteLine("Book is not available!");
						return null;
					}

				}
				



			}
			return null;
		}



		

		public Book ReturnBook(string name)
		{
			for (int i = 0; i < Books.Length; i++)
			{
				if (books[i]._name == name)
				{
					books[i]._isavailable = true;
					Console.WriteLine($"{books[i]._name} is available");
				}

				
			}
			return null;
		}

		public Book SearchByAuthor(string AuthorName)
		{
			for(int i=0; i < Books.Length; i++)
			{
				if (books[i]._author == AuthorName)
				{
                    Console.WriteLine(books[i]._name);
				}
			}return null;
		}
	}
}
