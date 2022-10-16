using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListenerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralCustomer()
	{
	}
}
