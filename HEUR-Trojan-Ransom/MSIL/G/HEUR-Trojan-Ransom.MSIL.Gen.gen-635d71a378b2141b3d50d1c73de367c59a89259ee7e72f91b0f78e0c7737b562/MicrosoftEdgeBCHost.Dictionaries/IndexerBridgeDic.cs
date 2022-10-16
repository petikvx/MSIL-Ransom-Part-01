using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IndexerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupClass()
	{
	}
}
