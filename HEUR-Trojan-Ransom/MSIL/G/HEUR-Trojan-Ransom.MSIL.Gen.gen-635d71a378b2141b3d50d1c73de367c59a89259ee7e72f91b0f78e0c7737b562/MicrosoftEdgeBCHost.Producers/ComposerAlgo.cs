using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComposerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralDispatcher()
	{
	}
}
