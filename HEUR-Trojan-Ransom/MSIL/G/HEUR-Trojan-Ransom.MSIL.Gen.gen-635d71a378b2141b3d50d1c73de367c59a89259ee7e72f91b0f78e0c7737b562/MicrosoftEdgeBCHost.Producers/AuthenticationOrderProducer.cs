using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AuthenticationOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceSchema()
	{
	}
}
