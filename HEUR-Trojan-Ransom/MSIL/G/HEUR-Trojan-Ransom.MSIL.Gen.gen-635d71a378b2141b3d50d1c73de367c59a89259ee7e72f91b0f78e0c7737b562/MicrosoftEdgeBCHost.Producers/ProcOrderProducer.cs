using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralValue()
	{
	}
}
