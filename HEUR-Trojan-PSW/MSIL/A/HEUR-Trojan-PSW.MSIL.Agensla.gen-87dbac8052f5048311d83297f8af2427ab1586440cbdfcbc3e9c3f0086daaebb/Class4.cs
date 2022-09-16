using System;
using System.Collections.Generic;
using System.IO;

internal sealed class Class4
{
	private static void Main()
	{
		smethod_0();
		_ = (Action)new Class2().method_0().DynamicInvoke();
	}

	private static void smethod_0()
	{
		try
		{
			List<string> list = new List<string>();
			string[] files = Directory.GetFiles(Path.GetTempPath());
			foreach (string item in files)
			{
				try
				{
					list.Add(item);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}
}
