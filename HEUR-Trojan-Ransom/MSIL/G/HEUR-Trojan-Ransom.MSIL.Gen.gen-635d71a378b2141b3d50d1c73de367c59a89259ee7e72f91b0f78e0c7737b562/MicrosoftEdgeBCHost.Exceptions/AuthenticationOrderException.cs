using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AuthenticationOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceConnection()
	{
	}
}
