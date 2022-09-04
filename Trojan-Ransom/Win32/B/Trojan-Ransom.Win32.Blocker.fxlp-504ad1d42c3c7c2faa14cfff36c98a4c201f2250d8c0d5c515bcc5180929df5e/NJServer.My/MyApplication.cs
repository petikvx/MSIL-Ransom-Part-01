using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace NJServer.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyApplication : ConsoleApplicationBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static MyApplication()
	{
		char_1 = new char[8];
		char[] array = new char[8];
		array[3] = '◱';
		array[0] = '㲫';
		array[7] = '֍';
		array[5] = 'ᥡ';
		array[6] = '㟇';
		array[2] = '⮿';
		array[1] = '㭉';
		array[4] = '㖘';
		string_0 = new string[1];
		char_0 = array;
		Class3.smethod_15();
	}
}
