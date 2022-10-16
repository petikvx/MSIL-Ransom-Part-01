using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterceptorValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceMessage()
	{
	}
}
