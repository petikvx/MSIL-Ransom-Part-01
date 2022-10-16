using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServiceRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PreparePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PreparePrototype()
	{
	}
}
