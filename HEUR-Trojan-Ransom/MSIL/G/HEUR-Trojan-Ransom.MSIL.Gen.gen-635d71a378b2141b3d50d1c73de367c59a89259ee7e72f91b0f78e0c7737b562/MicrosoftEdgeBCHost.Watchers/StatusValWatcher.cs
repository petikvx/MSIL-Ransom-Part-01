using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StatusValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfacePrototype()
	{
	}
}
