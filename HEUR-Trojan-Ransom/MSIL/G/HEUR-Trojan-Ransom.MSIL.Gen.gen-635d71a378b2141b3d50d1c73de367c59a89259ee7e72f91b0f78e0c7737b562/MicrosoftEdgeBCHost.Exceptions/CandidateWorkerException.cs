using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CandidateWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInfo()
	{
	}
}
