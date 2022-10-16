using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class QueueWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceResolver()
	{
	}
}
