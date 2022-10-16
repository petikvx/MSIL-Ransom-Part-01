using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class UtilsPropertyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsPropertyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
