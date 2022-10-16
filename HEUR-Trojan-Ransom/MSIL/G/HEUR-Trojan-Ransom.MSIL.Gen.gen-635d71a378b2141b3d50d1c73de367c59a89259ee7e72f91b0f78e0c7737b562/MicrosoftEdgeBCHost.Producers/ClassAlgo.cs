using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralResolver()
	{
	}
}
