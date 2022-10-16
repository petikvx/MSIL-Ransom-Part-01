using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProccesorValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
