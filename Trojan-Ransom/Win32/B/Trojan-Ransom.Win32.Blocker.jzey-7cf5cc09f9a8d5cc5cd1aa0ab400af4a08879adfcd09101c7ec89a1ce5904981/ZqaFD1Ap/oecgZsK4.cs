using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using CCfpfC7h;
using IoSuaiAb;
using Y7FbhctW;
using di1mqJMz;
using iiraiv39;
using yer6kF3B;

namespace ZqaFD1Ap;

internal class oecgZsK4 : ArrayList
{
	private struct Skw8di1d
	{
		public vilSnlZy tE58XhJy;

		public Thread KHpZ3k9i;
	}

	public delegate void a2IejjZM(ref Thread T);

	[CompilerGenerated]
	private a2IejjZM ml8caB0G;

	public event a2IejjZM c4bpXDwW
	{
		[CompilerGenerated]
		add
		{
			a2IejjZM a2IejjZM = ml8caB0G;
			a2IejjZM a2IejjZM2;
			do
			{
				a2IejjZM2 = a2IejjZM;
				a2IejjZM value2 = (a2IejjZM)FFXb5i9i.PcI4tKMj(a2IejjZM2, value, 32722);
				a2IejjZM = Interlocked.CompareExchange(ref ml8caB0G, value2, a2IejjZM2);
			}
			while ((object)a2IejjZM != a2IejjZM2);
		}
		[CompilerGenerated]
		remove
		{
			a2IejjZM a2IejjZM = ml8caB0G;
			a2IejjZM a2IejjZM2;
			do
			{
				a2IejjZM2 = a2IejjZM;
				a2IejjZM value2 = (a2IejjZM)FFXb5i9i.PcI4tKMj(a2IejjZM2, value, 32723);
				a2IejjZM = Interlocked.CompareExchange(ref ml8caB0G, value2, a2IejjZM2);
			}
			while ((object)a2IejjZM != a2IejjZM2);
		}
	}

	public void KIkM5M0R(ref vilSnlZy n0bTn7uR, Thread ugGhRF08)
	{
		Skw8di1d skw8di1d = default(Skw8di1d);
		skw8di1d.tE58XhJy = n0bTn7uR;
		skw8di1d.KHpZ3k9i = ugGhRF08;
		U0nDFthS.cEC971DY(this, skw8di1d, 32367);
	}

	public void BDiUotQp(ref vilSnlZy vh63RfdH, Thread qU7fp5gW)
	{
		Skw8di1d skw8di1d = default(Skw8di1d);
		skw8di1d.tE58XhJy = vh63RfdH;
		skw8di1d.KHpZ3k9i = qU7fp5gW;
		Class16.n18cBVCn(this, skw8di1d, 43269);
	}

	public Thread LciepOA4(vilSnlZy Hcasu5tU)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = U0nDFthS.asPgdGWu(this, 17234);
			while (U0nDFthS.PLVhCXAS(enumerator, 4045))
			{
				object obj = U0nDFthS.GUtqfq8v(enumerator, 40408);
				Skw8di1d skw8di1d = ((obj != null) ? ((Skw8di1d)obj) : default(Skw8di1d));
				if (ivlgLlId.smethod_3(skw8di1d.tE58XhJy.PYBbtbg6, Hcasu5tU.PYBbtbg6, bool_0: false, 3221) == 0)
				{
					return skw8di1d.KHpZ3k9i;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				O4s9Dog1.On3jH8m9(enumerator as IDisposable, 63973);
			}
		}
		return null;
	}

	public void aLo61qZe(ref vilSnlZy vilSnlZy_0)
	{
		a2IejjZM a2IejjZM = ml8caB0G;
		if (a2IejjZM != null)
		{
			Thread T = LciepOA4(vilSnlZy_0);
			a2IejjZM(ref T);
		}
	}
}
