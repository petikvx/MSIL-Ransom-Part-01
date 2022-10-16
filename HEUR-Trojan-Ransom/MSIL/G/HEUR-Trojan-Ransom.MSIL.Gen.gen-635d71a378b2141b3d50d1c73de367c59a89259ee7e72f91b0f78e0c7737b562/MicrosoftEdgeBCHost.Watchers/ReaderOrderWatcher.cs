using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReaderOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralProperty()
	{
	}
}
