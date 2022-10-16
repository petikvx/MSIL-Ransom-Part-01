using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CallRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallRule()
	{
	}
}
