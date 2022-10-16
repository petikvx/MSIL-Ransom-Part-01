using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IteratorBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
