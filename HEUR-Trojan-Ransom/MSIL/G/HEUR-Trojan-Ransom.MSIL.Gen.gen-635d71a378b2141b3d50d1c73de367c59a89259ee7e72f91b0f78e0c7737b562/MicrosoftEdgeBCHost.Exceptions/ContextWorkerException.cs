using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContextWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptRecord()
	{
	}
}
