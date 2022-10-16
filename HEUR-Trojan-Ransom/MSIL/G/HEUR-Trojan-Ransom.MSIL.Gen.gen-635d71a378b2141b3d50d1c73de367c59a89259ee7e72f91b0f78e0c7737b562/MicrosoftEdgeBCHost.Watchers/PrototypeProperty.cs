using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrototypeProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeProperty()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
