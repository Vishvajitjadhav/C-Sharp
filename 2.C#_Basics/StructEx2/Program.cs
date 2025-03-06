using System;

namespace StructEx2
{
	struct Book
	{
		public int bid;
		public string book_name;
		public double price;
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Book book = new Book();
			book.price = 550;
			book.book_name = "C-Sharp";
			book.bid = 143;

			Console.WriteLine(book.price);
			Console.WriteLine(book.book_name);
			Console.WriteLine(book.bid);
		}
	}
}
