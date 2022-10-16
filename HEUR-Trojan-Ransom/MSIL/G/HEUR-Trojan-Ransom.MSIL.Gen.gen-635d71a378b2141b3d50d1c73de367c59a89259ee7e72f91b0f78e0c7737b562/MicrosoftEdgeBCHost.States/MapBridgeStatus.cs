using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		GetParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetParam()
	{
	}
}
