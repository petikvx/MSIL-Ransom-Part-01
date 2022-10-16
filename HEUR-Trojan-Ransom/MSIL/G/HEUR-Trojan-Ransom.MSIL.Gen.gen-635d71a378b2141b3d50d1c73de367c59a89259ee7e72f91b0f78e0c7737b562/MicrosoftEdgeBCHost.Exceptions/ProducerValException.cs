using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProducerValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerValException()
	{
		WriterPropertyProducer.ResolveStub();
		DisableEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableEvent()
	{
	}
}
