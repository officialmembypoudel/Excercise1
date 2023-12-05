using System;
namespace Excercise1
{
	public class Car
	{
		private string brand;
		private int year;
		private float price;
		public Car(string brand, int year, float price)
		{
			this.brand = brand;
			this.year = year;
			this.price = price;

		}

		//creating a method to print cardetails as the variables are private

		public void PrintCarDetails()
		{
			Console.WriteLine($"The brand of car is {brand} made in {2023} has a price of ${price}.");
		}

	}
}

