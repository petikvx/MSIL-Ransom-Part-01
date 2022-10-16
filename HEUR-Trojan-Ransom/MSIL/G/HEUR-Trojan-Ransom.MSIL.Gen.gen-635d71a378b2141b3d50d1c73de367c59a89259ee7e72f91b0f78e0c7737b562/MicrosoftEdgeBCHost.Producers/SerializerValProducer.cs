using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SerializerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
