using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IndexerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralEvent()
	{
	}
}
