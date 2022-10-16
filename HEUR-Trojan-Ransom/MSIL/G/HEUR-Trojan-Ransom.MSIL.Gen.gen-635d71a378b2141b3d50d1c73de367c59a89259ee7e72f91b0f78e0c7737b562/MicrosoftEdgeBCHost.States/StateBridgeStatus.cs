using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StateBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CallAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallAdapter()
	{
	}
}
