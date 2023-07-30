using System;
namespace BlazinBookStore.Services
{
	public class LocalBooksService : IBooksService
	{
		static List<Book> _allBooks = new List<Book>
		{
			new Book
			{
				AuthorName = "John Smith",
				PublishingDate = new(2022, 10, 10),
				Title = "Blazor WebAssembly Guide"
			},

			new Book
			{
				AuthorName = "John Smith",
				PublishingDate = new(2023, 3, 18),
				Title = "Mastering Blazor WebAssembly"
			},

			new Book
			{
				AuthorName = "Rasheed Mozaffar",
				PublishingDate = new(2025, 10, 19),
				Title = "How to stay single FOREVER"
			},

			new Book
			{
				AuthorName = "An Asshole",
				PublishingDate = new(2023, 7, 29),
				Title = "How to be a sore loser in a discussion"
			}
		};

		public Task<List<Book>> GetAllBooksAsync()
		{
			return Task.FromResult(_allBooks);
		}
	}
}

