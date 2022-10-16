using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BaseDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
