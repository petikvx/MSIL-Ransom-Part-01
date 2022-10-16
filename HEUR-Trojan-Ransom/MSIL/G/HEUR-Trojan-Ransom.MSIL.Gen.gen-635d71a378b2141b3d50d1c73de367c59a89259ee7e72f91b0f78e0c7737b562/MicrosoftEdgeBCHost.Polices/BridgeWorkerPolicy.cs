using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BridgeWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceTest()
	{
	}
}
