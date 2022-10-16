using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StubOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubOrder()
	{
		WriterPropertyProducer.ResolveStub();
		PostSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostSerializer()
	{
	}
}
