using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CustomerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralEvent()
	{
	}
}
