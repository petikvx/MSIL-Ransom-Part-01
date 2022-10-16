using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BridgeOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceMessage()
	{
	}
}
