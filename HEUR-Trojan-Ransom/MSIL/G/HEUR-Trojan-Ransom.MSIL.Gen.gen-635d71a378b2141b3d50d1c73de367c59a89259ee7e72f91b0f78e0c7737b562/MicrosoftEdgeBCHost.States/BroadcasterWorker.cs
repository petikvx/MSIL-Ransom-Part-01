using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BroadcasterWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeAccount()
	{
	}
}
