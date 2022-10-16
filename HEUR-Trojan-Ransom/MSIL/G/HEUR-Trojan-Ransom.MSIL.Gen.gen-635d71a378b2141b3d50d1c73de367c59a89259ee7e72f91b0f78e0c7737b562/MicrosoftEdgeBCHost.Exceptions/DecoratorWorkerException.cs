using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		RateFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateFilter()
	{
	}
}
