using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListClass()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
