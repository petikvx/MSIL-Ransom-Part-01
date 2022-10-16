using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ObserverWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralManager()
	{
	}
}
