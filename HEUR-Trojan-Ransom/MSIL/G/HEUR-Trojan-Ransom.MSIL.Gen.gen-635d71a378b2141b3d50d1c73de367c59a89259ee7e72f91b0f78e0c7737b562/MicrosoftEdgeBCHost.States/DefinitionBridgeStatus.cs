using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DefinitionBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortListener()
	{
	}
}
