using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralContext()
	{
	}
}
