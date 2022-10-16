using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BridgeProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceProccesor()
	{
	}
}
