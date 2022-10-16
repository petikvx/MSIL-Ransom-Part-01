using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ListRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceQueue()
	{
	}
}
