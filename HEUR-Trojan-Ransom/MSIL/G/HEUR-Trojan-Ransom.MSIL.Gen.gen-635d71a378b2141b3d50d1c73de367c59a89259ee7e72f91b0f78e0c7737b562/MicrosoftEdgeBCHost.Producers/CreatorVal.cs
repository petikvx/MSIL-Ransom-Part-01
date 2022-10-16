using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CreatorVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorVal()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
