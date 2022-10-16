using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RulesWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceWatcher()
	{
	}
}
