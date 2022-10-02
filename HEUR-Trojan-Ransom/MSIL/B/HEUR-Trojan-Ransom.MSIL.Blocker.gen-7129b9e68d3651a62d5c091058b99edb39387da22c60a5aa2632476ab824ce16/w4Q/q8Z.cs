using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace w4Q;

internal sealed class q8Z
{
	internal sealed class Fq4
	{
		public delegate void Ap2(object sender, EventArgs e);

		private Ap2 ClickEvent;

		[SpecialName]
		public void t2E(Ap2 r7S)
		{
			Ap2 ap = ClickEvent;
			Ap2 ap2;
			do
			{
				ap2 = ap;
				Ap2 value = (Ap2)Delegate.Combine(ap2, r7S);
				ap = Interlocked.CompareExchange(ref ClickEvent, value, ap2);
			}
			while ((object)ap != ap2);
		}

		[SpecialName]
		public void w9L(Ap2 p6M)
		{
			Ap2 ap = ClickEvent;
			Ap2 ap2;
			do
			{
				ap2 = ap;
				Ap2 value = (Ap2)Delegate.Remove(ap2, p6M);
				ap = Interlocked.CompareExchange(ref ClickEvent, value, ap2);
			}
			while ((object)ap != ap2);
		}
	}

	internal sealed class d8E
	{
	}
}
