using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RepositoryBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
