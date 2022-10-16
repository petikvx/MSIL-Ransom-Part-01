using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttrValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyResolver()
	{
	}
}
