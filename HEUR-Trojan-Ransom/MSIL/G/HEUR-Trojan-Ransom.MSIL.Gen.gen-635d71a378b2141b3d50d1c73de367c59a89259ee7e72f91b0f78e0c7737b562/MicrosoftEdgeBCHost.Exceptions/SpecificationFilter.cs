using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SpecificationFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationFilter()
	{
		WriterPropertyProducer.ResolveStub();
		SortExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortExpression()
	{
	}
}
