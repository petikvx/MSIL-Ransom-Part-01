using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExpressionWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		RateDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateDefinition()
	{
	}
}
