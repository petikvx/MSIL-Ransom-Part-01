using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConfigurationWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralObject()
	{
	}
}
