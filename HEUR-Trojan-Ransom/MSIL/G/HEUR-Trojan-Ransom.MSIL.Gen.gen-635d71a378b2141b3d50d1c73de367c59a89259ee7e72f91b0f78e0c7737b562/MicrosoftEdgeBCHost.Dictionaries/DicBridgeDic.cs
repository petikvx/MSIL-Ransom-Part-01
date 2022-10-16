using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DicBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CollectReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectReader()
	{
	}
}
