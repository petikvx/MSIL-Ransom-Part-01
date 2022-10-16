using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProxyObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyObject()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralListener()
	{
	}
}
