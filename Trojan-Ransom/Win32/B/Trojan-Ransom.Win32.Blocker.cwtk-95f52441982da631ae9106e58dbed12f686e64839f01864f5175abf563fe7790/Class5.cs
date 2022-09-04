using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[StandardModule]
internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 33024)]
	private struct Struct2
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class5()
	{
		Class3.smethod_0();
		char_1 = new char[16512];
		char[] array = new char[8];
		array[2] = 'べ';
		array[1] = 'ឋ';
		array[6] = 'ᓃ';
		array[7] = 'ᢄ';
		array[0] = '⠫';
		array[4] = '㦓';
		array[5] = 'ö';
		array[3] = '⫬';
		string_0 = new string[6];
		char_0 = array;
	}
}
