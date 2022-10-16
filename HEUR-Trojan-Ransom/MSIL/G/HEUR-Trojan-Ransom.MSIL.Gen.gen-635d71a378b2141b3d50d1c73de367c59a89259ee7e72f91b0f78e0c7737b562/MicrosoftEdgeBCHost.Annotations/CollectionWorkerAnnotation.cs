using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CollectionWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
