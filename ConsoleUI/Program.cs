/**
* 2/15/2022
* CSC 153
* Gavin Watson
* Text Game with user input
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//Variables
			bool exit = false;
			int roomLocation = 0;



			// Arrays
			string[] rooms = new string[5] {"Glacial Planet", "Ash Planet", "Mystical Planet", "Desolate Planet", "Tropical Planet"};
			string[] weapons = new string[4] { "Air Sweeper", "Gun Lance", "Electro Beam", "Excalibur" };
			string[] potions = new string[2] { "Stamina Potion", "Decay Potion" };
			string[] treasures = new string[3] { "Crystal Skull", "Solar Core", "MSRP GPU(Legendary)" };

			// Lists
			List<string> items = new List<string>() { "Fuel Cell", "Broken Hyperdrive", "Oxygen Tank", "Van full of candy" };
			List<string> mobs = new List<string>() { "Ebay Scalper", "Frost Giant", "Ash Snake", "Wild Karen", "Ghoul" };

			//Main menu

			while (exit == false)
			{
				Console.WriteLine($"You are in - {rooms[roomLocation]}");
				Console.WriteLine("1. Display Rooms");
				Console.WriteLine("2. Display Weapons");
				Console.WriteLine("3. Display Potion");
				Console.WriteLine("4. Display Treasure");
				Console.WriteLine("5. Display Items");
				Console.WriteLine("6. Display Mobs");
				Console.WriteLine("7. Exit");
				Console.Write("Enter a choice > ");
				string input = Console.ReadLine();

				// user input
				switch(input.ToLower())
                {
					// All possible user choices
					case "1":
						foreach (string value in rooms)
                        {
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "2":
						foreach (string value in weapons)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "3":
						foreach (string value in potions)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "4":
						foreach (string value in treasures)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "5":
						foreach (string value in items)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "6":
						foreach (string value in mobs)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "rooms":
						foreach (string value in rooms)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "weapons":
						foreach (string value in weapons)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "potions":
						foreach (string value in potions)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "treasures":
						foreach (string value in treasures)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "items":
						foreach (string value in items)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "mobs":
						foreach (string value in mobs)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "n":
						if(roomLocation != 4)
                        {
							roomLocation++;
                        }
                        else
                        {
							Console.WriteLine("You are unable to travel north");
						}
						Console.WriteLine();
						break;
					case "s":
						if (roomLocation != 0)
						{
							roomLocation--;
						}
						else
						{
							Console.WriteLine("You are unable to travel south");
						}
						Console.WriteLine();
						break;
					default:
						Console.WriteLine("Not a choice!");
						break;
					case "7":
						exit = true;
						break;


				}
			}
		}
    }
}
