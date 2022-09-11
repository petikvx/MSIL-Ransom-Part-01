using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class0
{
	internal sealed class Class1
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 414)]
		private struct Struct0
		{
		}

		private static readonly object object_0;

		private static readonly object object_1;

		private static readonly Array array_0;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class1()
		{
			object_1 = new char[207];
			char[] array = new char[8];
			array[1] = '\u2fe5';
			array[4] = 'Ἷ';
			array[3] = '\u05a9';
			array[7] = 'ᗰ';
			array[0] = 'Ꮡ';
			array[5] = '㻾';
			array[2] = '㎶';
			array[6] = '㯷';
			array_0 = new string[27];
			object_0 = array;
		}
	}
}
