using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BaseWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
