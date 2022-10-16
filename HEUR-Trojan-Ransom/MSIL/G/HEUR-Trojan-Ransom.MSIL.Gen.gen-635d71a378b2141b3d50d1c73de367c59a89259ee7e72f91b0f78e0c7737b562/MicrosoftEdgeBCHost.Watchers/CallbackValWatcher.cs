using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CallbackValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceDispatcher()
	{
	}
}
