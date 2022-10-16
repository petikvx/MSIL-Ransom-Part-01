using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StrategyValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyValException()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectBroadcaster()
	{
	}
}
