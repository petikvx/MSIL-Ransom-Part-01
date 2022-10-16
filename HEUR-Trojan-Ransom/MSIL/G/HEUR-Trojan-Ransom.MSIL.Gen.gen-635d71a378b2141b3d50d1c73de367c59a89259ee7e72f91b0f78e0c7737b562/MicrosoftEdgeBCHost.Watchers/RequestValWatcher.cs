using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RequestValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceResolver()
	{
	}
}
