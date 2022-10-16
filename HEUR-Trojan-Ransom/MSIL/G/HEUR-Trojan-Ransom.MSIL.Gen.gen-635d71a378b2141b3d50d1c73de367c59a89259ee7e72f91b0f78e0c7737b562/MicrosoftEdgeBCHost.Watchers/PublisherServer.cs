using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PublisherServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherServer()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralFacade()
	{
	}
}
