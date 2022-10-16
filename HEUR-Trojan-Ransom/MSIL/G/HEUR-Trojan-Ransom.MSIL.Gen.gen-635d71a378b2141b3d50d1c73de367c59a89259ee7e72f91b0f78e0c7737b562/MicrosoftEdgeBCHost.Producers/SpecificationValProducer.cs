using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SpecificationValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateComparator()
	{
	}
}
