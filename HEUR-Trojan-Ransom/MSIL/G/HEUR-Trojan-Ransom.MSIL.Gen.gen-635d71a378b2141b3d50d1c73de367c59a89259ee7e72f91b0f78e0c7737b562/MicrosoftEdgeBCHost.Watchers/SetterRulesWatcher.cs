using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SetterRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RestartImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartImporter()
	{
	}
}
