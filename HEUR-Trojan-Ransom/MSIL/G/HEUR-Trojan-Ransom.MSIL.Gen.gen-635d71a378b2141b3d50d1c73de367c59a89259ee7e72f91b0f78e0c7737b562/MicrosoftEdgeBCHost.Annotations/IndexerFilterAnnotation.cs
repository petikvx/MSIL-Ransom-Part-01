using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IndexerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceTests()
	{
	}
}
