using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many details do you want to enter:");
			int size = Convert.ToInt32(Console.ReadLine());
			string[] arr = new string[size];
			int i;
			Console.WriteLine("Please enter the details:");
			for (i = 0; i < size; i++)
			{

				foreach (string s in Console.ReadLine().Split())
				{
					arr[i] = s;
					i++;
				}

			}

			foreach(var item in arr)
			{
				Console.WriteLine(item);

			}
			Console.Read();
		}
	}
}
