using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class EventContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventContext()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceWrapper()
	{
	}
}
