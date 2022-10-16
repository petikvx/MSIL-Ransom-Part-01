using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DicValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareMap()
	{
	}
}
