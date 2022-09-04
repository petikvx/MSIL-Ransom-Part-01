using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace Update.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct1
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}

	static MyComputer()
	{
		char_1 = new char[8];
		char[] array = new char[8];
		array[2] = '\u088f';
		array[3] = 'ኴ';
		array[1] = 'ա';
		array[6] = '▧';
		array[5] = 'ሡ';
		array[0] = '☈';
		array[7] = 'ߛ';
		array[4] = '㞬';
		string_0 = new string[1];
		char_0 = array;
	}
}
