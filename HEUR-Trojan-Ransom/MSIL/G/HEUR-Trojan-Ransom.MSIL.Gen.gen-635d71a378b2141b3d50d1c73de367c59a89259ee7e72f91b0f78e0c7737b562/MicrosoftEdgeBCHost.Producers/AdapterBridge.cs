using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdapterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
