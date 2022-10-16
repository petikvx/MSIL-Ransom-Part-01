using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralProperty()
	{
	}
}
