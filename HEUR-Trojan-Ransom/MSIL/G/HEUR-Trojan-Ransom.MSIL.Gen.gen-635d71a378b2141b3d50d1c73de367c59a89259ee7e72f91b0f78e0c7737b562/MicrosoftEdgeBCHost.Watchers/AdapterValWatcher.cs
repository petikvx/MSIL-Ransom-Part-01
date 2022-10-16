using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdapterValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceGetter()
	{
	}
}
