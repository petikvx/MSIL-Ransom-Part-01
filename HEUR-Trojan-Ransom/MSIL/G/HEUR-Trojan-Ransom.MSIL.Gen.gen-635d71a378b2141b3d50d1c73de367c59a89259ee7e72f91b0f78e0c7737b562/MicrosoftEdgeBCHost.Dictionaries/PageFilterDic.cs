using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PageFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralTests()
	{
	}
}
