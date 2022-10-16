using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
