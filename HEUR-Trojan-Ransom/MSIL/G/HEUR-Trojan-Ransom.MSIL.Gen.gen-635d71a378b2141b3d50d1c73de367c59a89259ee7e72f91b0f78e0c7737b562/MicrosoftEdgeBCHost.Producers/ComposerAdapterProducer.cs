using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComposerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
