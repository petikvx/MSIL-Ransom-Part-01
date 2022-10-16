using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ImporterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartComparator()
	{
	}
}
