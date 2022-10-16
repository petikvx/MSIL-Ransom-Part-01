using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttrExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrExpression()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
