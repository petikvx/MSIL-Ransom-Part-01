using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProxyFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyFilter()
	{
		WriterPropertyProducer.ResolveStub();
		AssetComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetComposer()
	{
	}
}
