using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProducerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralPublisher()
	{
	}
}
