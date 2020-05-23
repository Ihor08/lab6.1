using System;

public class Test
{

	interface Market
	{

		double kof();

	}

	class Product : Market
	{

		public int month = 1;
		public double plan = 0;
		public double fact = 0;

		public Product()
		{
			month = 1;
			plan = 0;
			fact = 0;
		}

		public double kof()
		{
			return (fact / plan) * 100;
		}

	}

	public static void Main()
	{

		Random rand = new Random();
		Product[] year = new Product[12];

		for (int i = 0; i < 12; i++)
		{
			year[i] = new Product();
			year[i].month = i + 1;
			year[i].plan = rand.Next() * 0.0001;
			year[i].fact = rand.Next() * 0.0001;

		}

		int month_max = 0;
		int month_min = 0;

		for (int i = 0; i < 12; i++)
		{

			if (year[month_max].kof() < year[i].kof())
			{
				month_max = i;
			}
			if (year[month_min].kof() > year[i].kof())
			{
				month_min = i;
			}
		}


		bool z = true;
		Product temp = new Product();

		while (z)
		{

			z = false;

			for (int i = 0; i < 11; i++)
			{

				if (year[i].kof() > year[i + 1].kof())
				{
					temp = year[i];
					year[i] = year[i + 1];
					year[i + 1] = temp;
					z = true;
				}

			}

		}

		Console.WriteLine("Max:");
		Console.WriteLine("Month: " + year[month_max].month + " " + "Plan: " + year[month_max].plan + " " + "Fact: " + year[month_max].fact);
		Console.WriteLine("Min:");
		Console.WriteLine("Month: " + year[month_min].month + " " + "Plan: " + year[month_min].plan + " " + "Fact: " + year[month_min].fact);


		Console.WriteLine("Table:");
		for (int i = 0; i < 12; i++)
		{
			Console.WriteLine("Month: " + year[i].month + " " + "Plan: " + year[i].plan + " " + "Fact: " + year[i].fact);
		}



	}
}
