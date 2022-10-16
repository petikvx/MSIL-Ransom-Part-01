using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BridgeUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeUtils()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceMap()
	{
	}
}
