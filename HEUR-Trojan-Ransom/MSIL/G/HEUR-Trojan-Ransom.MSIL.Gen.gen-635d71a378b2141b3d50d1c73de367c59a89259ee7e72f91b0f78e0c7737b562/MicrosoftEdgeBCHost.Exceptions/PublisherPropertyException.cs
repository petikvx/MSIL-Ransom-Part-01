using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PublisherPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralDispatcher()
	{
	}
}
