using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class EventWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventWorker()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeSystem()
	{
	}
}
