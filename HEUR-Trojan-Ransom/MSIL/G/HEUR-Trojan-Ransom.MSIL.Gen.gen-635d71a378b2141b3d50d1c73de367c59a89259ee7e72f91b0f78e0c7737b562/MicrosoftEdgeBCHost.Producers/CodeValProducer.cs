using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CodeValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
