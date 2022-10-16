using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WatcherBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareRule()
	{
	}
}
