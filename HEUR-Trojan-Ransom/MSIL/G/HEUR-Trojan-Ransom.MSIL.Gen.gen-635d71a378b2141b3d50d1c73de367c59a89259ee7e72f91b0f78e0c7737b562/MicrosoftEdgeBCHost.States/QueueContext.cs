using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class QueueContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueContext()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfacePublisher()
	{
	}
}
