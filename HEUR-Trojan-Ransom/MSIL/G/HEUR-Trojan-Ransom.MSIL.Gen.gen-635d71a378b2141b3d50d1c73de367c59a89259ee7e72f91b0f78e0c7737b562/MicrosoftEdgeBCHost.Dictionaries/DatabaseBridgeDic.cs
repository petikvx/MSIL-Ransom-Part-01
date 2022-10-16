using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DatabaseBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceBroadcaster()
	{
	}
}
