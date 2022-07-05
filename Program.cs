using System;

namespace Spooder
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to SPOODER!\nYou can generate random strings here that are as long as you want!\na: 6 characters long\nb: 8 characters long\nc:12 characters long\nd: 16 characters long\n e: 20 characters long\n\nPress H to bring this menu again.\n\n\n\nPlease note that SPOODER only uses CHARACTERS[letters] in the random generation. Use NAUTICAL(coming soon) for numbers + letters. Use SEAL(coming soon) if you want characters + numbers + symbols!");
			while(true)
			{
			
				ConsoleKey KeyPressed;
				ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
				KeyPressed = KeyInfo.Key;	
				if (KeyPressed == ConsoleKey.H)
				{
					Console.Clear();
					Console.WriteLine("Welcome to SPOODER!\nYou can generate random strings here that are as long as you want!\na: 6 characters long\nb: 8 characters long\nc:12 characters long\nd: 16 characters long\n e: 20 characters long\n\nPress H to bring this menu again.\n\n\n\nPlease note that SPOODER only uses CHARACTERS[letters] in the random generation. Use NAUTICAL(coming soon) for numbers + letters. Use SEAL(coming soon) if you want characters + numbers + symbols!");
				}		
				Random rnd = new Random();
				string[] chars = {"a","b","c","d","e","f","g","h","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
				int index = rnd.Next(chars.Length);
				int index2 = rnd.Next(chars.Length);
				int index3 = rnd.Next(chars.Length);
				int index4 = rnd.Next(chars.Length);
				int index5 = rnd.Next(chars.Length);
				int index6 = rnd.Next(chars.Length);
				int index7 = rnd.Next(chars.Length);
				int index8 = rnd.Next(chars.Length);
				int index9 = rnd.Next(chars.Length);
				int index10 = rnd.Next(chars.Length);
				int index11 = rnd.Next(chars.Length);
				int index12 = rnd.Next(chars.Length);
				int index13 = rnd.Next(chars.Length);
				int index14 = rnd.Next(chars.Length);
				int index15 = rnd.Next(chars.Length);
				int index16 = rnd.Next(chars.Length);
				int index17 = rnd.Next(chars.Length);
				int index18 = rnd.Next(chars.Length);
				int index19 = rnd.Next(chars.Length);
				int index20 = rnd.Next(chars.Length);								
				if (KeyPressed == ConsoleKey.A)
				{
					Console.Clear();
					Console.WriteLine(chars[index]+chars[index2]+chars[index3]+chars[index4]+chars[index5]+chars[index6]);

				}
				else if(KeyPressed == ConsoleKey.B)
				{
					Console.Clear();
					Console.WriteLine(chars[index]+chars[index2]+chars[index3]+chars[index4]+chars[index5]+chars[index6]+chars[index7]+chars[index8]);
				}
				else if(KeyPressed == ConsoleKey.C)
				{
					Console.Clear();
					Console.WriteLine(chars[index]+chars[index2]+chars[index3]+chars[index4]+chars[index5]+chars[index6]+chars[index7]+chars[index8]+chars[index9]+chars[index10]+chars[index11]+chars[index12]);
				}
				else if(KeyPressed == ConsoleKey.D)
				{
					Console.Clear();
					Console.WriteLine(chars[index]+chars[index2]+chars[index3]+chars[index4]+chars[index5]+chars[index6]+chars[index7]+chars[index8]+chars[index9]+chars[index10]+chars[index11]+chars[index12]+chars[index13]+chars[index14]+chars[index15]+chars[index16]);
				}
				else if(KeyPressed == ConsoleKey.E)
				{
					Console.Clear();
					Console.WriteLine(chars[index]+chars[index2]+chars[index3]+chars[index4]+chars[index5]+chars[index6]+chars[index7]+chars[index8]+chars[index9]+chars[index10]+chars[index11]+chars[index12]+chars[index13]+chars[index14]+chars[index15]+chars[index16]+chars[index17]+chars[index18]+chars[index19]+chars[index20]);
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Welcome to SPOODER!\nYou can generate random strings here that are as long as you want!\na: 6 characters long\nb: 8 characters long\nc:12 characters long\nd: 16 characters long\n e: 20 characters long\n\nPress H to bring this menu again.\n\n\n\nPlease note that SPOODER only uses CHARACTERS[letters] in the random generation. Use NAUTICAL(coming soon) for numbers + letters. Use SEAL(coming soon) if you want characters + numbers + symbols!");

				}
			}
		}
	}
}