using System;
using System.IO;

namespace xbot_wpf.Common;

public static class Const
{
	public static string RegistryValue;

	public static string DataDirectory => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "XBot");

	static Const()
	{
		Class24.nhQmSIPz7n4eU();
		RegistryValue = "430543";
	}
}
