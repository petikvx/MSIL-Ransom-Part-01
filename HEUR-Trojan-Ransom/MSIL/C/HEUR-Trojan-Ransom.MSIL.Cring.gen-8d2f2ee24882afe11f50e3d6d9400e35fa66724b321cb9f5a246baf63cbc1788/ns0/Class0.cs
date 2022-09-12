using System;
using System.Windows.Forms;

namespace ns0;

internal static class Class0
{
	[STAThread]
	private static void Main()
	{
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new GForm0());
	}

	private static string smethod_0(string string_0)
	{
		int length = string_0.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = string_0[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
