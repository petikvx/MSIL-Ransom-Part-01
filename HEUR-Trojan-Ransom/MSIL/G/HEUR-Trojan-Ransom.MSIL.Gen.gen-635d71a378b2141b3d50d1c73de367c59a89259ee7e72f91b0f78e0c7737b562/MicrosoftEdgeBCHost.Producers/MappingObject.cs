using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MappingObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingObject()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
