using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DispatcherWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		QueryIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryIterator()
	{
	}
}
