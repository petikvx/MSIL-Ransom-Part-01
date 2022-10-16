using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PageBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostReader()
	{
	}
}
