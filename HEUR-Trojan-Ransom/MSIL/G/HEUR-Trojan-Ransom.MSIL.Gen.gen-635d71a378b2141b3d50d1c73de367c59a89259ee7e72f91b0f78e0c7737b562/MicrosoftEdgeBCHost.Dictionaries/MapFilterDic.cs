using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralFactory()
	{
	}
}
