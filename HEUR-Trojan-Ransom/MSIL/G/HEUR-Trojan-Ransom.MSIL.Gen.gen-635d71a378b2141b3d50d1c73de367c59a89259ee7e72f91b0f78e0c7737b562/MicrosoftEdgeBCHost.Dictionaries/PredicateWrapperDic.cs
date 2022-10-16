using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PredicateWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareRules()
	{
	}
}
