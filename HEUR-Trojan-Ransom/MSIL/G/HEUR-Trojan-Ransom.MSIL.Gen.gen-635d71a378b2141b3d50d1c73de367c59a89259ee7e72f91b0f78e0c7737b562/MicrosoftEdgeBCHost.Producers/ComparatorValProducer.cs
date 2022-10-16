using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComparatorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeStatus()
	{
	}
}
