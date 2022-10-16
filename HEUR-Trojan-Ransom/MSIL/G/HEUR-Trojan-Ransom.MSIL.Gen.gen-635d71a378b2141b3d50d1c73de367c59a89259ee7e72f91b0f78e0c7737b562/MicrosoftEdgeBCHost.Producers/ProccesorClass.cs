using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProccesorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorClass()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
