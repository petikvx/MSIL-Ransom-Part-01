using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BroadcasterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralMock()
	{
	}
}
