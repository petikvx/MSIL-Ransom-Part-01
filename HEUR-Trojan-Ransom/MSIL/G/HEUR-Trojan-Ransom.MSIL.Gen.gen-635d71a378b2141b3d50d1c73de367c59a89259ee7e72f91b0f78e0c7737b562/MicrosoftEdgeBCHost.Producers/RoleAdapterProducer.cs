using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RoleAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
