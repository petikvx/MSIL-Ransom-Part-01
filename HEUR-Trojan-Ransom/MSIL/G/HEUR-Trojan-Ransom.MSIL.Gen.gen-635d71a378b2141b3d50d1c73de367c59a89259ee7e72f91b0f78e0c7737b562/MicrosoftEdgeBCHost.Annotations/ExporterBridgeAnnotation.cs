using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExporterBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RestartResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartResolver()
	{
	}
}
