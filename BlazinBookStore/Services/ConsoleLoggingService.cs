using System;
namespace BlazinBookStore.Services
{
	public class ConsoleLoggingService : ILoggingService
	{
		public ConsoleLoggingService()
		{
		}

		/// <summary>
		/// This method logs a message to the console window
		/// </summary>
		/// <param name="message">the message to be logged</param>
		public void Log(string message)
		{
			Console.WriteLine($"Console Log At: {DateTime.Now} >> Message: {message}");
		}
	}
}

