using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InitializerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InitProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitProduct()
	{
	}
}
