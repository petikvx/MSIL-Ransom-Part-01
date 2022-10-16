using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SingletonAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
