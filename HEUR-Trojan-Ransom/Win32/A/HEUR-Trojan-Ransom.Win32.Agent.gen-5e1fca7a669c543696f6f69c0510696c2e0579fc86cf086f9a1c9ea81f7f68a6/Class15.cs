using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;

internal sealed class Class15
{
	public static List<string[]> smethod_0()
	{
		List<string[]> list = new List<string[]>();
		list.Add(new string[3] { "Adware:Win32/Hotbar", "Moderate", "Hotbar displays a dynamic toolbar and targeted pop-up ads based on its monitoring of Web-browsing activity." });
		list.Add(new string[3] { "Adware:Win32/SideTab ", "Low", "Adware:Win32/SideTab is the multi-component detection for adware that installs a Browser Helper Object (BHO) that may redirect the browser to certain websites." });
		list.Add(new string[3] { "Backdoor:Win32/Cycbot.B", "Severe!", "Backdoor:Win32/Cycbot.B is a backdoor trojan that allows attackers unauthorized access and control of an affected computer. " });
		list.Add(new string[3] { "Worm:Win32/Conficker.B", "Severe!", "Worm:Win32/Conficker.B is a worm that infects other computers across a network by exploiting a vulnerability in the Windows Server service (SVCHOST.EXE)." });
		list.Add(new string[3] { "Trojan:HTML/Phishbank.U", "Severe!", "Trojan:HTML/Phishbank.U is a trojan that attempts to steal sensitive information related to online banking." });
		list.Add(new string[3] { "Virus:Win32/Virut.BN", "Severe!", "Virus:Win32/Virut.BN is a detection for a polymorphic file infector that targets .EXE and .SCR Windows files." });
		list.Add(new string[3] { "Adware:Win32/GameVance", "Moderate", "Adware:Win32/GameVance is detection for advertising components that display advertisements and track anonymous usage information in exchange for free online gaming." });
		list.Add(new string[3] { "Trojan:Win32/Rimecud.A", "Severe!", "Trojan:Win32/Rimecud.A is a malicious program that is unable to spread of its own accord. " });
		list.Add(new string[3] { "Adware:Win32/Gabpath", "Moderate", "Adware:Win32/Gabpath is adware that creates pop-up notification-style advertisements based on the user's web browsing habits." });
		list.Add(new string[3] { "Trojan:Win32/Calelk.A", "Severe!", "Trojan:Win32/Calelk.A is a trojan that gains control of the infected computer by locking the screen and preventing the user from using the computer." });
		list.Add(new string[3] { "Trojan:Win32/Ircbrute", "Severe!", "Trojan:Win32/Ircbrute is a generic detection for multiple families of malware." });
		list.Add(new string[3] { "BrowserModifier:Win32/BaiduSobar", "Moderate!", "BrowserModifier:Win32/Baidu.Sobar is a Web browser toolbar that delivers pop-up and contextual advertisements." });
		return list;
	}

	public static string smethod_1(int int_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		string text = "Select * From Win32_Process Where ProcessID = " + int_0;
		ManagementObjectSearcher val = new ManagementObjectSearcher(text);
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				string[] array = new string[2]
				{
					string.Empty,
					string.Empty
				};
				if (Convert.ToInt32(val3.InvokeMethod("GetOwner", (object[])array)) == 0)
				{
					return array[1] + "\\" + array[0];
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return "NO OWNER";
	}

	public static DateTime smethod_2(Process process_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		string text = "select CreationDate from Win32_Process where ProcessId='" + process_0.Id + "'";
		SelectQuery val = new SelectQuery(text);
		ManagementScope val2 = new ManagementScope("\\\\.\\root\\CIMV2");
		ManagementObjectSearcher val3 = new ManagementObjectSearcher(val2, (ObjectQuery)(object)val);
		ManagementObjectCollection val4 = val3.Get();
		ManagementObjectEnumerator enumerator = val4.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val5 = (ManagementObject)enumerator.get_Current();
				return ManagementDateTimeConverter.ToDateTime(((ManagementBaseObject)val5).get_Item("CreationDate").ToString());
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return DateTime.MaxValue;
	}

	public static string smethod_3(string string_0, int int_0)
	{
		string_0 = string_0.Replace("\n", " ");
		string_0 = string_0.Replace("\r", " ");
		string_0 = string_0.Replace(".", ". ");
		string_0 = string_0.Replace(">", "> ");
		string_0 = string_0.Replace("\t", " ");
		string_0 = string_0.Replace(",", ", ");
		string_0 = string_0.Replace(";", "; ");
		string_0 = string_0.Replace(" ", " ");
		string[] array = string_0.Split(new char[1] { ' ' });
		int num = 0;
		ArrayList arrayList = new ArrayList(string_0.Length / int_0);
		string text = string.Empty;
		bool flag = false;
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			if (text2.Length <= 0)
			{
				continue;
			}
			if (text2.Substring(0, 1) == "<")
			{
				flag = true;
			}
			if (flag)
			{
				text = ((!text.EndsWith(".")) ? (text + " " + text2) : (text + text2));
				if (text2.IndexOf(">") > -1)
				{
					flag = false;
				}
			}
			else if (num + text2.Length + 1 < int_0)
			{
				text = text + " " + text2;
				num += text2.Length + 1;
			}
			else
			{
				arrayList.Add(text);
				text = text2;
				num = text2.Length;
			}
		}
		if (text != string.Empty)
		{
			arrayList.Add(text);
		}
		string text3 = string.Empty;
		foreach (string item in arrayList)
		{
			text3 += item;
			text3 += "\n";
		}
		return text3;
	}
}
