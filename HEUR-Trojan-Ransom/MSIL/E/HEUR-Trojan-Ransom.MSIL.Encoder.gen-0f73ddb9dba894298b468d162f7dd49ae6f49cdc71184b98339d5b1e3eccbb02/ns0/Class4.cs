using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using KamelAmenThaabet;

namespace ns0;

internal static class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 60098)]
	private struct Struct0
	{
	}

	internal sealed class Class5
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[30049];

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[SecuritySafeCritical]
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}

	static Class4()
	{
		char[] array = new char[8];
		array[6] = 'ƈ';
		array[0] = '㯾';
		array[2] = 'ᒍ';
		array[1] = '㹸';
		array[3] = 'ṋ';
		array[4] = '\u0887';
		array[5] = '৷';
		array[7] = '㣇';
		string_0 = new string[390];
		char_0 = array;
	}
}
