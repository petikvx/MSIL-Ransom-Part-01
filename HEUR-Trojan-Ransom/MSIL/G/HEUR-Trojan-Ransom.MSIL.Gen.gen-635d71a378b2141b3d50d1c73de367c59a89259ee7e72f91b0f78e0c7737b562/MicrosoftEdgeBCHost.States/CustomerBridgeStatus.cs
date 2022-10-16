using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CustomerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		GetInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInfo()
	{
	}
}
