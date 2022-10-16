using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AlgoPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceRepository()
	{
	}
}
