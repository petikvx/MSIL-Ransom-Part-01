using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CollectionBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotDefinition()
	{
	}
}
