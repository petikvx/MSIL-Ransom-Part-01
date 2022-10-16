using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AuthenticationUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralRule()
	{
	}
}
