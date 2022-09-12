using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using LoginModern;

namespace ns0;

internal static class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 15819)]
	private struct Struct1
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct2
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[8];

	private static readonly string[] string_0;

	internal static byte byte_1/* Not supported: data(00) */;

	[SecuritySafeCritical]
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new login());
	}

	static Class0()
	{
		char[] array = new char[8];
		array[7] = 'ဿ';
		array[0] = '㐂';
		array[5] = '⟒';
		array[2] = 'ℕ';
		array[1] = '၇';
		array[3] = '⎊';
		array[6] = '⪒';
		array[4] = '㭅';
		string_0 = new string[1];
		char_0 = array;
	}
}
