using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FilterValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceFactory()
	{
	}
}
