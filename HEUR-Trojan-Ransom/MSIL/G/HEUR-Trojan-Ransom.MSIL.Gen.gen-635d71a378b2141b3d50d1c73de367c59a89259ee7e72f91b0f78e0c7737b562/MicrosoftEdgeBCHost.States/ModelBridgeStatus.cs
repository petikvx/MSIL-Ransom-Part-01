using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ModelBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortRules()
	{
	}
}
