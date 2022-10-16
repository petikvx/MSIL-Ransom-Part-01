using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AuthenticationState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationState()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceException()
	{
	}
}
