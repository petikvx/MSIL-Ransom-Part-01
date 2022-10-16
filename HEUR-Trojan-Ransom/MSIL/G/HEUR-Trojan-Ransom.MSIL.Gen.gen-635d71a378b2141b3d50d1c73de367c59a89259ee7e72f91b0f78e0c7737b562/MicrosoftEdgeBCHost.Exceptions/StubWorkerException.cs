using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StubWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeQueue()
	{
	}
}
