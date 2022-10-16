using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CreatorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateAdapter()
	{
	}
}
