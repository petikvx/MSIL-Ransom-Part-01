using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamsFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AssetContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetContainer()
	{
	}
}
