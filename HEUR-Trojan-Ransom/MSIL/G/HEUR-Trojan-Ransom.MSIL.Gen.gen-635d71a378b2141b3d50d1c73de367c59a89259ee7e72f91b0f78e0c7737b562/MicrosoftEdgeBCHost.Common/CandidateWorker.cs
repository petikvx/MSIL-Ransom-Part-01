using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateWorker()
	{
		WriterPropertyProducer.ResolveStub();
		SetList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetList()
	{
	}
}
