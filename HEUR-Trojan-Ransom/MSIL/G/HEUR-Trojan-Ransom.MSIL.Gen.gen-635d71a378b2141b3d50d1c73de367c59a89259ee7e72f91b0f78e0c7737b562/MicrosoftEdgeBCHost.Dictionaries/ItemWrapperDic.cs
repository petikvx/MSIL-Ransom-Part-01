using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ItemWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillPredicate()
	{
	}
}
