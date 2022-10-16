using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BridgeFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceObserver()
	{
	}
}
