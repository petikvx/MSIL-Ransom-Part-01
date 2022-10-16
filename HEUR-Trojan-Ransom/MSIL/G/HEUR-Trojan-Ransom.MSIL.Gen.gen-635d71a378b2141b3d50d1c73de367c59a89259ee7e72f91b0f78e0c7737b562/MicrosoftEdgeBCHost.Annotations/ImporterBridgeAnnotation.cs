using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ImporterBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		EnableMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableMapping()
	{
	}
}
