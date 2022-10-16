using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RuleRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CheckExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckExporter()
	{
	}
}
