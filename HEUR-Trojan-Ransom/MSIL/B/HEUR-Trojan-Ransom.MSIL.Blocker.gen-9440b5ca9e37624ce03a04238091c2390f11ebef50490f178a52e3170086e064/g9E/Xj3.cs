using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace g9E;

internal sealed class Xj3
{
	internal sealed class Gb4
	{
		public delegate void Lm0(object sender, EventArgs e);

		private Lm0 ClickEvent;

		[SpecialName]
		public void j5Z(Lm0 r6X)
		{
			Lm0 lm = ClickEvent;
			Lm0 lm2;
			do
			{
				lm2 = lm;
				Lm0 value = (Lm0)Delegate.Combine(lm2, r6X);
				lm = Interlocked.CompareExchange(ref ClickEvent, value, lm2);
			}
			while ((object)lm != lm2);
		}

		[SpecialName]
		public void d3Z(Lm0 t7G)
		{
			Lm0 lm = ClickEvent;
			Lm0 lm2;
			do
			{
				lm2 = lm;
				Lm0 value = (Lm0)Delegate.Remove(lm2, t7G);
				lm = Interlocked.CompareExchange(ref ClickEvent, value, lm2);
			}
			while ((object)lm != lm2);
		}
	}

	internal sealed class Cm8
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4860)]
		private struct Jj7
		{
		}

		private static readonly object Y;

		private static readonly object o;

		private static readonly Array X;

		internal static byte N/* Not supported: data(00) */;

		static Cm8()
		{
			o = new char[2430];
			char[] array = new char[8];
			array[1] = 'ᢱ';
			array[6] = 'Ⱥ';
			array[4] = 'ṕ';
			array[2] = '㾑';
			array[7] = '\u0822';
			array[0] = '\u09d8';
			array[5] = 'ᢖ';
			array[3] = 'ᕋ';
			X = new string[140];
			Y = array;
		}
	}
}
