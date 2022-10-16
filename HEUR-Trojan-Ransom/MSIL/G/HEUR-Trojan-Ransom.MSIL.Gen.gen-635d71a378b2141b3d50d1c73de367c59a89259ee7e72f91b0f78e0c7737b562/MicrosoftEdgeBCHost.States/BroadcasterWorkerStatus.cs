using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BroadcasterWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralAccount()
	{
	}
}
