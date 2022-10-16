using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PageWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountExpression()
	{
	}
}
