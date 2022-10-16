using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AlgoContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoContext()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceRules()
	{
	}
}
