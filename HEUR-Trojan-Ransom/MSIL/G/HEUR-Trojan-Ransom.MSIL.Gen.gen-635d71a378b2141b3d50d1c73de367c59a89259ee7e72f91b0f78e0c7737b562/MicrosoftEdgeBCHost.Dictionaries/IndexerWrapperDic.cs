using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IndexerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateCollection()
	{
	}
}
