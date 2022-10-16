using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CandidateWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareAuthentication()
	{
	}
}
