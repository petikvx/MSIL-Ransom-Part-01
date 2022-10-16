using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListenerFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralInterceptor()
	{
	}
}
