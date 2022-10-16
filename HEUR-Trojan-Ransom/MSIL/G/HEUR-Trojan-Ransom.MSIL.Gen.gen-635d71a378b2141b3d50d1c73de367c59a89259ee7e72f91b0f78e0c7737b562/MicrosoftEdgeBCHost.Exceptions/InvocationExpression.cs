using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InvocationExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralAttr()
	{
	}
}
