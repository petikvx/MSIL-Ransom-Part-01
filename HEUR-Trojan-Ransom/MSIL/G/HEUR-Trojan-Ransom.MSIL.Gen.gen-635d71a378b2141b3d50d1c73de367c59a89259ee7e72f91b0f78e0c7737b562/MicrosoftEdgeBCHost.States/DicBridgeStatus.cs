using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DicBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ViewVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewVal()
	{
	}
}
