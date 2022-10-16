using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExpressionAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
