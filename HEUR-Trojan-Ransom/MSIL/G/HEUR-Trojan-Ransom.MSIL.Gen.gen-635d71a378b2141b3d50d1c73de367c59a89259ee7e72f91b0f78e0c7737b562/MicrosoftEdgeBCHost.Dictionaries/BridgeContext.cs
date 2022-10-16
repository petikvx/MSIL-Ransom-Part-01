using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BridgeContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeContext()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceClient()
	{
	}
}
