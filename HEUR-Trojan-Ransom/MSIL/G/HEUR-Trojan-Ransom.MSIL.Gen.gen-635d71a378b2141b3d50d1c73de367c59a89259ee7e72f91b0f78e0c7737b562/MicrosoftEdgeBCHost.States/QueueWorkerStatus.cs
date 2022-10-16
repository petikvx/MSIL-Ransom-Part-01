using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class QueueWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralSingleton()
	{
	}
}
