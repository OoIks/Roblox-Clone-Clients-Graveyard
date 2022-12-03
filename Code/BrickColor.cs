// BrickColor
using System;

public class BrickColor
{
	public static string Random()
	{
		Random random = new Random();
		return $"#{random.Next(16777216):X6}";
	}
}
