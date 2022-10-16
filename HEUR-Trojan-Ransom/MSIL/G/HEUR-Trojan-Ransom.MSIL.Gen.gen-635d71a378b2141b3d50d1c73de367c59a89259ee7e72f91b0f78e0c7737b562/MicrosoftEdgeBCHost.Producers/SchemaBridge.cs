using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SchemaBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaBridge()
	{
		WriterPropertyProducer.ResolveStub();
		VisitResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitResolver()
	{
	}
}
