using System;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class5
{
	public static void smethod_0()
	{
		new GClass0<a>();
		GClass5<a> ginterface6_ = new GClass5<a>(5);
		GClass5<a> gClass = new GClass5<a>(5);
		int num = 1;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 2);
		int num2 = 0;
		while (num2 <= 21 && gClass.imethod_4() < 5)
		{
			Console.WriteLine();
			smethod_1(gClass);
			Console.WriteLine(Class7.smethod_0(-1566193308), num2);
			if (num2 > 21)
			{
				break;
			}
			Console.Write(Class7.smethod_0(-1566193289));
		}
		Console.WriteLine();
		if (num2 <= 21)
		{
			Console.WriteLine(Class7.smethod_0(-1566193339));
			smethod_1(ginterface6_);
		}
		else
		{
			Console.WriteLine(Class7.smethod_0(-1566193367));
		}
	}

	public static void smethod_1<TCards>(GInterface6<TCards> ginterface6_0) where TCards : GInterface7
	{
		foreach (GInterface7 item in ginterface6_0.imethod_0())
		{
			Console.WriteLine(item.ToString());
		}
		Console.WriteLine();
	}
}
