using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WriterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PushComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushComparator()
	{
	}
}
