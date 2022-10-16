using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InstanceWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralReader()
	{
	}
}
