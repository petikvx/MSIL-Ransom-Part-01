using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DescriptorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
