using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AuthenticationPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceProcess()
	{
	}
}
