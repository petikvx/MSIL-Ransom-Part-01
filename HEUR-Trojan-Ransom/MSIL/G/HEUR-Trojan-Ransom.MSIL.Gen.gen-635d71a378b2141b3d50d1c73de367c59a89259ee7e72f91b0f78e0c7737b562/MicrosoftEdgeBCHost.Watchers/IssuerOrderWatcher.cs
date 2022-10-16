using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IssuerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralRequest()
	{
	}
}
