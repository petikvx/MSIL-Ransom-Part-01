using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AuthenticationValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CountCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountCallback()
	{
	}
}
