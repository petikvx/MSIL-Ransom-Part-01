using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class VisitorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceCreator()
	{
	}
}
