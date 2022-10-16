using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BaseOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralMock()
	{
	}
}
