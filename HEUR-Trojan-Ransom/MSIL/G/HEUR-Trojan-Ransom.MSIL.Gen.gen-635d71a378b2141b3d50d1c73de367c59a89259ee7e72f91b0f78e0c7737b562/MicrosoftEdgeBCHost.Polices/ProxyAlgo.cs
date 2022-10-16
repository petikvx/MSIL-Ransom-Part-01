using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProxyAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralStatus()
	{
	}
}
