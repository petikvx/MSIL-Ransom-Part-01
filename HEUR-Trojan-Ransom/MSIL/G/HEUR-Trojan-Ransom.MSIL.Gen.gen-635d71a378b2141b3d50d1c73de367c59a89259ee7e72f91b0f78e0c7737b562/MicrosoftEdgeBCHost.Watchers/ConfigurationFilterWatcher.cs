using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConfigurationFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadThread()
	{
	}
}
