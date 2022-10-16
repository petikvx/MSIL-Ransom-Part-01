using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenizerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeTests()
	{
	}
}
