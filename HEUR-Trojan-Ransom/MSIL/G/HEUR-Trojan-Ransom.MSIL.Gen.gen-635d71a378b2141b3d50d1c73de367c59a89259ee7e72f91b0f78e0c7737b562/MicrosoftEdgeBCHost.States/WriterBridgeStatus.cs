using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WriterBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CompareListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareListener()
	{
	}
}
