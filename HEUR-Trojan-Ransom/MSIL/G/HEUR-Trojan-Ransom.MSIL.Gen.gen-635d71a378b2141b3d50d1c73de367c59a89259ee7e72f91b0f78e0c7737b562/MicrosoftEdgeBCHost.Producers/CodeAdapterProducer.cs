using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CodeAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
