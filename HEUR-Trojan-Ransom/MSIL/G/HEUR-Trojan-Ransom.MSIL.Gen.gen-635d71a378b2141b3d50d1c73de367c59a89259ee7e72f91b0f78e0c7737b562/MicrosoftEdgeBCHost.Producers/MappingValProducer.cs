using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MappingValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareVisitor()
	{
	}
}
