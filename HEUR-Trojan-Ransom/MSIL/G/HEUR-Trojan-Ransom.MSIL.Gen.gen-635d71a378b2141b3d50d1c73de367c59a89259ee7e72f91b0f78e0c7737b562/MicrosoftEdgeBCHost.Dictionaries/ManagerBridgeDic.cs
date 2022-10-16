using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ManagerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceBroadcaster()
	{
	}
}
