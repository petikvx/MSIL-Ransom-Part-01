using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ImporterFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralBroadcaster()
	{
	}
}
