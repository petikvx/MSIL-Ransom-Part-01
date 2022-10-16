using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StructRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructRules()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
