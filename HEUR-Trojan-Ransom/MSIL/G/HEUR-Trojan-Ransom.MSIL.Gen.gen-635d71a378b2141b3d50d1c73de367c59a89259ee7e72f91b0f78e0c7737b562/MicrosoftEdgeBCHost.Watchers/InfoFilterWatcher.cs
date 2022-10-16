using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InfoFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AssetToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetToken()
	{
	}
}
