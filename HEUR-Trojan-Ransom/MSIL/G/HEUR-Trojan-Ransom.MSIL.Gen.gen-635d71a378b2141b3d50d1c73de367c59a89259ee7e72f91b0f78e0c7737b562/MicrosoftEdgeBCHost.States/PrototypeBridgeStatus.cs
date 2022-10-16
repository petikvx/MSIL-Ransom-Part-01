using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrototypeBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ManageParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageParams()
	{
	}
}
