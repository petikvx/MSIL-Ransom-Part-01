using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InstanceSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
