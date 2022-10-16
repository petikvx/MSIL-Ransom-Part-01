using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IteratorWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfacePublisher()
	{
	}
}
