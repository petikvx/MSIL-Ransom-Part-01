using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AuthenticationContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationContext()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfacePublisher()
	{
	}
}
