using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ThreadFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadFacade()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralConsumer()
	{
	}
}
