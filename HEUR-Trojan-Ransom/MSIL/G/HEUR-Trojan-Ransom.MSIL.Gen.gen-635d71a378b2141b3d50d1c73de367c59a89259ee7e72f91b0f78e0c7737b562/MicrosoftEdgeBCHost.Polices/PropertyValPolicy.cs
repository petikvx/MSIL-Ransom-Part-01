using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PropertyValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
