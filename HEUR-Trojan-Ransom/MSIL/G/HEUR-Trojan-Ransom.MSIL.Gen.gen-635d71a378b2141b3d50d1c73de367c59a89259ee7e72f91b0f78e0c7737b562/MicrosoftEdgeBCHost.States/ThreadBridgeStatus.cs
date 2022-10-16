using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ThreadBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareProduct()
	{
	}
}
