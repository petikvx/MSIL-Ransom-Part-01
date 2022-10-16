using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PageExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageExpression()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
