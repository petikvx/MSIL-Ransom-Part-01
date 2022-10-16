using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class UtilsClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsClass()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
