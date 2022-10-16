using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WatcherValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralStatus()
	{
	}
}
