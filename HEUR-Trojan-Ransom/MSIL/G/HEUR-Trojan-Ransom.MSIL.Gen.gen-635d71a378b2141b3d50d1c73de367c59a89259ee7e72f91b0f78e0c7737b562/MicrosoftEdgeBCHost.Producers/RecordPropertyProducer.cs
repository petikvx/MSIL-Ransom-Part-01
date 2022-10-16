using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RecordPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
