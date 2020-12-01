using System;
using System.Diagnostics;

namespace C_Tests
{
    class Program
	{
        static void Main(string[] args)
		{
			string teabags = "do you have enough teabags? Y/N";
			string kettleOn = "is the kettle on? Y/N";
			string addWaterFirst = "do you add milk? Y/N";
			string addSugar = "do you take sugar with your tea? Y/N";
			string response;

			do
			{

				Console.WriteLine(teabags);
				response = Console.ReadLine();
				if (response == "N")
				{
					Console.WriteLine(" Buy more teabags ");
				}
			}
			while (response == "N");

			do
			{
				Console.WriteLine(kettleOn);
				response = Console.ReadLine();
				if (response == "N")
				{
					Console.WriteLine(" Turn Kettle on ");
				}
			}
			while (response == "N");

			Console.WriteLine(addWaterFirst);
			response = Console.ReadLine();
			if (response == "Y")
			{
				addWaterFirst = " milk? ";
			}
			else
			{
				addWaterFirst = " no milk ";
			}

			Console.WriteLine(addSugar);
			response = Console.ReadLine();
			if (response == "Y")
			{
				Console.WriteLine("tea completed with sugar and" + addWaterFirst);
			}
			else
			{
				Console.WriteLine("tea completed with no sugar and" + addWaterFirst);
			}
		}

	}

}


	