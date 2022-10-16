using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ObjectWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceProducer()
	{
	}
}
