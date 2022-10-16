using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BroadcasterFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterFacade()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralItem()
	{
	}
}
