using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InvocationProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationProperty()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
