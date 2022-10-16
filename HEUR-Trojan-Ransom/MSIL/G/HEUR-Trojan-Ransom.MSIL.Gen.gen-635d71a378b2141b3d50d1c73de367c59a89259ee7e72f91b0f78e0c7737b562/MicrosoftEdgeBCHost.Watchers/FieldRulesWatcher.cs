using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FieldRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RestartMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartMap()
	{
	}
}
