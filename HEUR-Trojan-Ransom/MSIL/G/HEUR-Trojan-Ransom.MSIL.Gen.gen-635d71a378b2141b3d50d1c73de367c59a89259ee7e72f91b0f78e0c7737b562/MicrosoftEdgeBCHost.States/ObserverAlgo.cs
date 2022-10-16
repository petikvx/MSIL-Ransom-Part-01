using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObserverAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralTag()
	{
	}
}
