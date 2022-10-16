using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AuthenticationObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationObject()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralListener()
	{
	}
}
