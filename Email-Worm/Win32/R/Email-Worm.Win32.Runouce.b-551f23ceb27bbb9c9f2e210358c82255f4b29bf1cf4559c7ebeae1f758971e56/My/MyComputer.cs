using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 443334)]
	private struct Struct0
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
		char_1 = new char[221667];
		char[] array = new char[8];
		array[6] = 'ʋ';
		array[2] = 'ɪ';
		array[0] = 'ᵩ';
		array[4] = 'ℨ';
		array[7] = '\u0eeb';
		array[3] = '⦾';
		array[5] = '㗜';
		array[1] = '㚴';
		string_0 = new string[1104];
		char_0 = array;
	}
}
