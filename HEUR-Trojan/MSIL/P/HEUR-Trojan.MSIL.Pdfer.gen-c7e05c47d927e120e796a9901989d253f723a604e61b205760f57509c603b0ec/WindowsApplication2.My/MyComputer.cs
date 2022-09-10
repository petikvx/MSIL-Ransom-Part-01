using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace WindowsApplication2.My;

[GeneratedCode("MyTemplate", "10.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class MyComputer : Computer
{
	internal sealed class Class0
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19190)]
		private struct Struct0
		{
		}

		private static bool bool_0;

		private static readonly Array array_0;

		private static readonly object object_0;

		private static readonly object object_1;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class0()
		{
			object_0 = new char[9595];
			char[] array = new char[8];
			array[5] = '\u2df5';
			array[1] = 'ޔ';
			array[4] = 'ᦞ';
			array[6] = '୪';
			array[2] = 'ᑥ';
			array[7] = 'ఛ';
			array[0] = '⌺';
			array[3] = '᭕';
			object_1 = new string[722];
			array_0 = array;
		}
	}

	internal sealed class Class1
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}
}
