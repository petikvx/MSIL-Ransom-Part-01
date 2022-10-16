using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ListBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AssetPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetPublisher()
	{
	}
}
