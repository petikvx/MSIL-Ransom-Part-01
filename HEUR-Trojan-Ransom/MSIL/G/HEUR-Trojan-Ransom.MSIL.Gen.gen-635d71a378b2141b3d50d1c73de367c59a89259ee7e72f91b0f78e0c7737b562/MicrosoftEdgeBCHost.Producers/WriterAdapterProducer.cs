using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WriterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralMapper()
	{
	}
}
