using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CandidateFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralGlobal()
	{
	}
}
