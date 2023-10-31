using System.Globalization;

string[] snacks = { "sushi", "pizza", "burger", "chicken", "Asian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are poing to eat {snacks[randomIndex]}.");