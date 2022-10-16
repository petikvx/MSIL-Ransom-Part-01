using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WorkerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceWriter()
	{
	}
}
