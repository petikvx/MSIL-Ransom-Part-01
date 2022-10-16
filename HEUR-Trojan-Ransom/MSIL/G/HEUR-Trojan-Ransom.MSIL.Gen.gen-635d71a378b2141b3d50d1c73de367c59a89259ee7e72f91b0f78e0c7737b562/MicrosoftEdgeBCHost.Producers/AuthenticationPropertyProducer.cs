using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AuthenticationPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
