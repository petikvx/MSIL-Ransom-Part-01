using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AuthenticationOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceObserver()
	{
	}
}
