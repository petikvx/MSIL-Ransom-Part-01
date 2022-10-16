using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class EventWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PushState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushState()
	{
	}
}
