using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolServer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralContainer()
	{
	}
}
