using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServerAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralInterceptor()
	{
	}
}
