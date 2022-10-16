using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PublisherWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PostModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostModel()
	{
	}
}
