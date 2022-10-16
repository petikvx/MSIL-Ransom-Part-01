using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class UtilsValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceEvent()
	{
	}
}
