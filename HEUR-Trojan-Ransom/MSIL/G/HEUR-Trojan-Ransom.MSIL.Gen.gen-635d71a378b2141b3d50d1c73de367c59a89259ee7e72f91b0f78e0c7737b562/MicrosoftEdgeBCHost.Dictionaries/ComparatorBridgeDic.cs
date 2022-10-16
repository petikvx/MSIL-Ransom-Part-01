using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComparatorBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapCreator()
	{
	}
}
