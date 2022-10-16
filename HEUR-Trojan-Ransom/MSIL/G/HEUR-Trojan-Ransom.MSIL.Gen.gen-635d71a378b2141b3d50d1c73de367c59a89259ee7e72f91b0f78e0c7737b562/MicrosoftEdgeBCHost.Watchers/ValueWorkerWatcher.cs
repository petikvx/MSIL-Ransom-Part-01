using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValueWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceWriter()
	{
	}
}
