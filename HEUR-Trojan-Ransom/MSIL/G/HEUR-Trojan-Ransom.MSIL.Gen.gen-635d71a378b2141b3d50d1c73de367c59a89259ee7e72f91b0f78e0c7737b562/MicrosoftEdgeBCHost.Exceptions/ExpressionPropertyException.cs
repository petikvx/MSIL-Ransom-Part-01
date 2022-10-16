using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExpressionPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralQueue()
	{
	}
}
