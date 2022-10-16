using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ModelWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralConnection()
	{
	}
}
