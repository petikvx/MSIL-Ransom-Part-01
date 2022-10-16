using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamsAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralAdapter()
	{
	}
}
