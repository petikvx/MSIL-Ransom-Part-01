using System;
using System.Runtime.InteropServices;

internal sealed class F
{
	internal sealed class N
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 88922)]
		private struct D
		{
		}

		private static readonly Array T;

		private static readonly object L;

		private static readonly Array E;

		internal static byte H/* Not supported: data(00) */;

		static N()
		{
			L = new char[44461];
			char[] array = new char[8];
			array[4] = '㋵';
			array[2] = 'ᾧ';
			array[1] = 'Ӈ';
			array[5] = 'Ⴐ';
			array[3] = '\u08e3';
			array[7] = '\u0a70';
			array[6] = '⋎';
			array[0] = '\u0b4c';
			E = new string[8];
			T = array;
		}
	}

	internal sealed class D
	{
		internal sealed class K
		{
		}
	}
}
