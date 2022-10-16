using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenizerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CountCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountCandidate()
	{
	}
}
