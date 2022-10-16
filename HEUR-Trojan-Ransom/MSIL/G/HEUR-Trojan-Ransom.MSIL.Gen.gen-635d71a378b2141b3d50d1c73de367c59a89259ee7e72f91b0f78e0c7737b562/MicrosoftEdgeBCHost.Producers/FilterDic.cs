using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
