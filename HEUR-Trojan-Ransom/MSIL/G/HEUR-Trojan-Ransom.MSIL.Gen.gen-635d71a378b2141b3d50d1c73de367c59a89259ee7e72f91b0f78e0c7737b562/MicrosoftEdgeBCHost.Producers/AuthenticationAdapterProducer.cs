using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AuthenticationAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
