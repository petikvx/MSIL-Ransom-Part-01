using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CollectionDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralTask()
	{
	}
}
