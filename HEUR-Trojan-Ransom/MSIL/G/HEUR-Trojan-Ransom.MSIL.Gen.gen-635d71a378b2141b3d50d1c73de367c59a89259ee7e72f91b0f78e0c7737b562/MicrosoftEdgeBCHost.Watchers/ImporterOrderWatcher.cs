using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ImporterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralWatcher()
	{
	}
}
