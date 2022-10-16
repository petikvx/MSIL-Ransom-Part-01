using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WatcherBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VisitValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitValue()
	{
	}
}
