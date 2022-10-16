using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValueAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralAdapter()
	{
	}
}
