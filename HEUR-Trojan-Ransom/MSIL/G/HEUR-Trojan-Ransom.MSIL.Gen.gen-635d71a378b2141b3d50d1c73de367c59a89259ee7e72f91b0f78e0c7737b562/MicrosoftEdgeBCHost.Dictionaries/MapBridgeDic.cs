using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PostList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostList()
	{
	}
}
