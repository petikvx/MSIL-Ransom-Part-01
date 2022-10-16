using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BridgeOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceHelper()
	{
	}
}
