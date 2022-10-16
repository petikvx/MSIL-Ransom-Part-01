using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BroadcasterAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceIssuer()
	{
	}
}
