using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralInfo()
	{
	}
}
