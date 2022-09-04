using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic.Devices;

namespace aaaaaaaa.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 256)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}

	[SecuritySafeCritical]
	static MyComputer()
	{
		char_1 = new char[128];
		char[] array = new char[8];
		array[7] = '⁃';
		array[6] = 'ᴼ';
		array[3] = '℆';
		array[1] = 'ỻ';
		array[2] = '\u0825';
		array[5] = '\u0e5c';
		array[0] = 'ጩ';
		array[4] = '㠢';
		string_0 = new string[6];
		char_0 = array;
	}
}
