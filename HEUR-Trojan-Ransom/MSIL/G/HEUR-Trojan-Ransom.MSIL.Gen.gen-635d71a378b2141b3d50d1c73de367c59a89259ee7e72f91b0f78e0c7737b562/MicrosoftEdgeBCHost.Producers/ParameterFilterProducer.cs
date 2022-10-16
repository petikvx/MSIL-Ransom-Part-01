using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParameterFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
