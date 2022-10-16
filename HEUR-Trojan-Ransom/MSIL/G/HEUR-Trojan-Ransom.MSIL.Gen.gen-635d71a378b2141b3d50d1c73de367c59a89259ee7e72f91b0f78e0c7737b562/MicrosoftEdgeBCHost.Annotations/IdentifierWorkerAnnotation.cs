using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IdentifierWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
