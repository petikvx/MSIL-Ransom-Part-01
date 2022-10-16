using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AuthenticationAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralConsumer()
	{
	}
}
