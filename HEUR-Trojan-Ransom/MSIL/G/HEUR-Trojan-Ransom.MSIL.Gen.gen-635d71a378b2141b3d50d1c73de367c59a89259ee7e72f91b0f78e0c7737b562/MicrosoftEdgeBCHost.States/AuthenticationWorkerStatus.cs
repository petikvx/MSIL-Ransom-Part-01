using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AuthenticationWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralWrapper()
	{
	}
}
