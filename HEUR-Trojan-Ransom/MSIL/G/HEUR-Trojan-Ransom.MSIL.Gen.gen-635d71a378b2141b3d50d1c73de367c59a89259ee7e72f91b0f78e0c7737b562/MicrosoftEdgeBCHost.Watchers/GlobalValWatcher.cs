using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GlobalValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceCustomer()
	{
	}
}
