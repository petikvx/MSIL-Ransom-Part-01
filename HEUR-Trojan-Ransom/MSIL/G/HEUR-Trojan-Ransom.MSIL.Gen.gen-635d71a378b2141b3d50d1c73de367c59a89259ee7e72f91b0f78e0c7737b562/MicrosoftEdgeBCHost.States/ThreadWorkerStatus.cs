using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ThreadWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralObserver()
	{
	}
}
