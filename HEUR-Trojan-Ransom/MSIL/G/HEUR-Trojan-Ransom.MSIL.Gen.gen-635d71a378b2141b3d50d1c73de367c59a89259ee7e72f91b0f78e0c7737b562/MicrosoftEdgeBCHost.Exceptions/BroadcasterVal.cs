using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BroadcasterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterVal()
	{
		WriterPropertyProducer.ResolveStub();
		AssetWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetWrapper()
	{
	}
}
