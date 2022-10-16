using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RecordWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceReader()
	{
	}
}
