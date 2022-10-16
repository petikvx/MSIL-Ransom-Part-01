using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ModelRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceQueue()
	{
	}
}
