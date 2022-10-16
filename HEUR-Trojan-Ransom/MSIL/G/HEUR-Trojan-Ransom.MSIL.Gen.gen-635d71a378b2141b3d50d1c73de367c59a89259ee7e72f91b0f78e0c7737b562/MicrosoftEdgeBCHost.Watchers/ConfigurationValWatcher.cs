using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConfigurationValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceListener()
	{
	}
}
