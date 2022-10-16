using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CandidateRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceStub()
	{
	}
}
