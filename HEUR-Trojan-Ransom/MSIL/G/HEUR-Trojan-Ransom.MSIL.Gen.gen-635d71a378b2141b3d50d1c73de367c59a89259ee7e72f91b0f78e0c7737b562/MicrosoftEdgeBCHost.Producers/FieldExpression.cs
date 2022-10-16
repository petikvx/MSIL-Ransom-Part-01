using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FieldExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldExpression()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
