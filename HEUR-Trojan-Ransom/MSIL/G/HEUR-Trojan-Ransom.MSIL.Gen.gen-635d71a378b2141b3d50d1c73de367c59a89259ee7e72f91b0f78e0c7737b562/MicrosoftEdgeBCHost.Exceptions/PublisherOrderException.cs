using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PublisherOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceIdentifier()
	{
	}
}
