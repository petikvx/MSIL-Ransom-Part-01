using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ModelValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VisitMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitMock()
	{
	}
}
