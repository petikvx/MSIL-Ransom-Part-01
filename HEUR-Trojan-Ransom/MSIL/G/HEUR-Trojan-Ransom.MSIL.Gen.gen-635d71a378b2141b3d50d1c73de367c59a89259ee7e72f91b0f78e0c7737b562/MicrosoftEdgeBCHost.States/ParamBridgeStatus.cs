using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateDispatcher()
	{
	}
}
