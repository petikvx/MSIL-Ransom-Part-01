using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InfoHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoHelper()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
