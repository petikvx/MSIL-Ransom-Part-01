using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SpecificationOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralPublisher()
	{
	}
}
