using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParameterFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
