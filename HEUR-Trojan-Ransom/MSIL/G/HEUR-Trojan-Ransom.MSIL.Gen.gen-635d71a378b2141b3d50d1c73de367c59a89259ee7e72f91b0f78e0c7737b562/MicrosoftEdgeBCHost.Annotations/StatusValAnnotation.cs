using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StatusValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
