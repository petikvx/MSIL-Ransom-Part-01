using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComposerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteStrategy()
	{
	}
}
