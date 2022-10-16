using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class QueueWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceAnnotation()
	{
	}
}
