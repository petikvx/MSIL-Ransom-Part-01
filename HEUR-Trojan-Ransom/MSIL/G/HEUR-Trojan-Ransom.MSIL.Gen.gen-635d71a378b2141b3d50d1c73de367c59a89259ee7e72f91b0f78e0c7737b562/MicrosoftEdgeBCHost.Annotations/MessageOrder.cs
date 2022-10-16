using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MessageOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageOrder()
	{
		WriterPropertyProducer.ResolveStub();
		OrderObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderObserver()
	{
	}
}
