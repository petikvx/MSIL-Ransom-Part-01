using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BridgeAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralMessage()
	{
	}
}
