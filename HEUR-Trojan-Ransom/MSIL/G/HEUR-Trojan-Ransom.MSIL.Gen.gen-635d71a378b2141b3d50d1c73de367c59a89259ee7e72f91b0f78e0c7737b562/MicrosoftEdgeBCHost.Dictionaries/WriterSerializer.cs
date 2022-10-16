using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WriterSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralAlgo()
	{
	}
}
