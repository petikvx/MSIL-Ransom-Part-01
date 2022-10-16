using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WatcherAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceError()
	{
	}
}
