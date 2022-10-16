using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MockOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
