using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InstancePropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstancePropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
