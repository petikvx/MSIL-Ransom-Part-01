using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PageBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateMap()
	{
	}
}
