using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DispatcherAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceFactory()
	{
	}
}
