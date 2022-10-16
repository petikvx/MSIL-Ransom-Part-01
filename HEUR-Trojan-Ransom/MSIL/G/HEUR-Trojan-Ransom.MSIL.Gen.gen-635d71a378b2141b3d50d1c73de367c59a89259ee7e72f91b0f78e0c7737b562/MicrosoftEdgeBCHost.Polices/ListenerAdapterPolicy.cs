using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListenerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralStrategy()
	{
	}
}
