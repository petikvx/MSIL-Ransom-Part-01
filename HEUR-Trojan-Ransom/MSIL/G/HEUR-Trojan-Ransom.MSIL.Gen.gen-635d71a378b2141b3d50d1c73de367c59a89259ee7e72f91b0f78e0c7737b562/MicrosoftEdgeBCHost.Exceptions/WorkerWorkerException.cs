using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WorkerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		FlushVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushVal()
	{
	}
}
