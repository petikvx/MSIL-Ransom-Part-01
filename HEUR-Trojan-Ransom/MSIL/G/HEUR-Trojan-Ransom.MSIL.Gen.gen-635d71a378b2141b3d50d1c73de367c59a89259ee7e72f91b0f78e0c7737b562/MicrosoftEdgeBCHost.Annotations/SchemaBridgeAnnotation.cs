using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SchemaBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DisableAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableAlgo()
	{
	}
}
