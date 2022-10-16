using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class QueueWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PushDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushDatabase()
	{
	}
}
