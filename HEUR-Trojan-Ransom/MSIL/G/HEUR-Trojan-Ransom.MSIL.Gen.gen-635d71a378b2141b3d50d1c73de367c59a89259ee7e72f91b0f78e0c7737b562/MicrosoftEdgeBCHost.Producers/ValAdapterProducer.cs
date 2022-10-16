using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralMapping()
	{
	}
}
