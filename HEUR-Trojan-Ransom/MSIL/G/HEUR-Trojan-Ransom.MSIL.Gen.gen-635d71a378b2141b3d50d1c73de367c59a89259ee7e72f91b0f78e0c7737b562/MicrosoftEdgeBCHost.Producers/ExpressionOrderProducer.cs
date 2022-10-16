using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExpressionOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
