using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonObject()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralAuthentication()
	{
	}
}
