using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DispatcherRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherRules()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInitializer()
	{
	}
}
