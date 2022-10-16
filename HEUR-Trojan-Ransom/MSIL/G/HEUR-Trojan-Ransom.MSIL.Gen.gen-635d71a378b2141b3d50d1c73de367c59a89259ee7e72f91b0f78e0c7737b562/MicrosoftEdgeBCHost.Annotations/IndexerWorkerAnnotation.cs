using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IndexerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralProperty()
	{
	}
}
