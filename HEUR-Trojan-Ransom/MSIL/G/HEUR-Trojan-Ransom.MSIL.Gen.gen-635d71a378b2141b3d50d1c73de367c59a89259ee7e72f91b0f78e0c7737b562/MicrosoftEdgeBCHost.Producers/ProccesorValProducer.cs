using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProccesorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
