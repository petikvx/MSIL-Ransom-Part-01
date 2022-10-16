using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StrategyFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceListener()
	{
	}
}
