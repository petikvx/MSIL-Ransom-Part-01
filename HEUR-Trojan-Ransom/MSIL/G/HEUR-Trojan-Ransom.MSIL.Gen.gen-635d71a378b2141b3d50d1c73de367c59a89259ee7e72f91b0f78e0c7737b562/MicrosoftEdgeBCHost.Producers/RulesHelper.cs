using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RulesHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesHelper()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
