using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Re2;

internal sealed class Pt4
{
	internal sealed class Fo7
	{
		public delegate void f1M(object sender, EventArgs e);

		private f1M ClickEvent;

		[SpecialName]
		public void x5Y(f1M Ho1)
		{
			f1M f1M = ClickEvent;
			f1M f1M2;
			do
			{
				f1M2 = f1M;
				f1M value = (f1M)Delegate.Combine(f1M2, Ho1);
				f1M = Interlocked.CompareExchange(ref ClickEvent, value, f1M2);
			}
			while ((object)f1M != f1M2);
		}

		[SpecialName]
		public void Wm7(f1M x2N)
		{
			f1M f1M = ClickEvent;
			f1M f1M2;
			do
			{
				f1M2 = f1M;
				f1M value = (f1M)Delegate.Remove(f1M2, x2N);
				f1M = Interlocked.CompareExchange(ref ClickEvent, value, f1M2);
			}
			while ((object)f1M != f1M2);
		}
	}

	internal sealed class j0H
	{
	}
}
