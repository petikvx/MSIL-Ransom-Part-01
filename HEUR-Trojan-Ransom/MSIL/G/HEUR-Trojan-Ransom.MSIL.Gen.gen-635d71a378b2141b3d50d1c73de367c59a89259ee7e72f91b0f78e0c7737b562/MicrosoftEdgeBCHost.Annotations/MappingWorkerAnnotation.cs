using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MappingWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralProducer()
	{
	}
}
