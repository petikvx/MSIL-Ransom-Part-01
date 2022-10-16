using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class EventState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventState()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceDispatcher()
	{
	}
}
