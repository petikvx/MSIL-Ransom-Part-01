using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ImporterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
