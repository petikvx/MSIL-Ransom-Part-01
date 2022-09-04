using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	internal sealed class Class1
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 722107)]
		private struct Struct1
		{
		}

		internal static byte byte_0/* Not supported: data(00) */;
	}

	internal sealed class Class2
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		private struct Struct2
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class2()
		{
			char_1 = new char[8];
			char[] array = new char[8];
			array[1] = 'ⵦ';
			array[4] = 'ἆ';
			array[2] = 'њ';
			array[5] = '\u1ba4';
			array[0] = '⺨';
			array[6] = '\u0c48';
			array[3] = 'Ḍ';
			array[7] = '㕳';
			string_0 = new string[1];
			char_0 = array;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}
}
