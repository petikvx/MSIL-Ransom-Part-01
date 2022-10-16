using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AuthenticationFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostDecorator()
	{
	}
}
