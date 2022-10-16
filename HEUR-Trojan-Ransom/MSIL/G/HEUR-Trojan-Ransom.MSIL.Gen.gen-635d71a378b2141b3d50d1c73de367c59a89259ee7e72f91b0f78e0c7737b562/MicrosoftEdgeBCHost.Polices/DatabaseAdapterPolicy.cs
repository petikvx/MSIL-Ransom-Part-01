using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DatabaseAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
