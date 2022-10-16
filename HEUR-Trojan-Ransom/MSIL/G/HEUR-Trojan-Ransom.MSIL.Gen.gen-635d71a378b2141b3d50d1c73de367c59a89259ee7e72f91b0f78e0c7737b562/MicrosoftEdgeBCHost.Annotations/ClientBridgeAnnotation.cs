using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClientBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostExporter()
	{
	}
}
