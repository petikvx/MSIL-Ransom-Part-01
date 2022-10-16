using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DispatcherWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherWorker()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInvocation()
	{
	}
}
