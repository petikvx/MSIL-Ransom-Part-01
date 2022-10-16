using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttrAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralSetter()
	{
	}
}
