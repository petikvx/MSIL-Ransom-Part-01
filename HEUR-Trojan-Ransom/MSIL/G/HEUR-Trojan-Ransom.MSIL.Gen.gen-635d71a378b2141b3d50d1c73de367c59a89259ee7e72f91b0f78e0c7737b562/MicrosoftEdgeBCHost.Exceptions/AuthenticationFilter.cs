using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AuthenticationFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationFilter()
	{
		WriterPropertyProducer.ResolveStub();
		DisableComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableComposer()
	{
	}
}
