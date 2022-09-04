using System;
using System.Runtime.InteropServices;

internal sealed class Class1
{
	internal sealed class Class2
	{
		internal sealed class Class3
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2120)]
			private struct Struct2
			{
			}

			private static readonly object object_0;

			private static readonly Array array_0;

			private static readonly Array array_1;

			internal static byte byte_0/* Not supported: data(00) */;

			static Class3()
			{
				array_0 = new char[1060];
				char[] array = new char[8];
				array[2] = 'ᣍ';
				array[7] = 'ナ';
				array[5] = '෫';
				array[3] = '᧾';
				array[1] = '㢆';
				array[4] = '⛲';
				array[6] = '⥈';
				array[0] = '༇';
				array_1 = new string[122];
				object_0 = array;
			}
		}
	}
}
