using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class UtilsValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
