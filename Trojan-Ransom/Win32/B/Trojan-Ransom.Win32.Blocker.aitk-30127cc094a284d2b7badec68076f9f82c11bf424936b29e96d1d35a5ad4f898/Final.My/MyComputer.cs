using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace Final.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 462)]
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

	static MyComputer()
	{
		char_1 = new char[231];
		char[] array = new char[8];
		array[2] = 'Ⲩ';
		array[4] = '㉌';
		array[7] = '㢔';
		array[6] = '⟛';
		array[3] = 'ථ';
		array[0] = '㇟';
		array[5] = '⿀';
		array[1] = '\u0309';
		string_0 = new string[10];
		char_0 = array;
	}
}
