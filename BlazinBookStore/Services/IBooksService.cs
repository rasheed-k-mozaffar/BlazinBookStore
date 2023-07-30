using System;

namespace BlazinBookStore.Services
{
	public interface IBooksService
	{
		Task<List<Book>> GetAllBooksAsync();
	}
}

