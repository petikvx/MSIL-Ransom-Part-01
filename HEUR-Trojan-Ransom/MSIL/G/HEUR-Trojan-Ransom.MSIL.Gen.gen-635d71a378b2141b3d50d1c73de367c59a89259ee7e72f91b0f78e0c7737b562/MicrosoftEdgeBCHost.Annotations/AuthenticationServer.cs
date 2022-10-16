using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AuthenticationServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationServer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralIterator()
	{
	}
}
