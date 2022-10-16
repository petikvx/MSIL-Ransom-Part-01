using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PoolBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceService()
	{
	}
}
