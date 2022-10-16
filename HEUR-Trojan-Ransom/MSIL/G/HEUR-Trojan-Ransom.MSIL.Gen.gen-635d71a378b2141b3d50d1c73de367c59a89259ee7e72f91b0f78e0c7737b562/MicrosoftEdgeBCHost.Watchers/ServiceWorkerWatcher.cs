using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServiceWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralObject()
	{
	}
}
