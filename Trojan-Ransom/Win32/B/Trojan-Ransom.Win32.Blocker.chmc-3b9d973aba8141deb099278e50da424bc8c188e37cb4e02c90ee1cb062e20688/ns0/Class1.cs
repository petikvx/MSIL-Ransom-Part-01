using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class1
{
	internal sealed class Class2
	{
		internal sealed class Class3
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
			private struct Struct0
			{
			}

			private static bool bool_0;

			private static readonly char[] char_0;

			private static readonly char[] char_1;

			private static readonly string[] string_0;

			internal static byte byte_0/* Not supported: data(00) */;

			static Class3()
			{
				char_1 = new char[43];
				char[] array = new char[8];
				array[5] = '⡆';
				array[0] = '\u0c3a';
				array[7] = '\u0732';
				array[2] = 'Ō';
				array[4] = 'ჱ';
				array[3] = '\u1b34';
				array[6] = '↊';
				array[1] = 'ᇇ';
				string_0 = new string[1];
				char_0 = array;
			}
		}
	}

	internal sealed class Class4
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 108)]
		private struct Struct1
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class4()
		{
			char_1 = new char[54];
			char[] array = new char[8];
			array[1] = 'Ἤ';
			array[2] = '\u0abe';
			array[6] = '\u1dc9';
			array[4] = 'ˠ';
			array[7] = '∠';
			array[3] = '\u192b';
			array[0] = '⣅';
			array[5] = '⎗';
			string_0 = new string[4];
			char_0 = array;
		}
	}
}
