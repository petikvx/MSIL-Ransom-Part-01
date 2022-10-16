using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RecordFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
