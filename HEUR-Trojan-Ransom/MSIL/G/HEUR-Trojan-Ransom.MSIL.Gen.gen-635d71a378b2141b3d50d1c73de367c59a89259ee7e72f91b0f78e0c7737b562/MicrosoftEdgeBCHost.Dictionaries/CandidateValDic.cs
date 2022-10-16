using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CandidateValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralThread()
	{
	}
}
