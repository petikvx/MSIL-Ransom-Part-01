using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AuthenticationWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceQueue()
	{
	}
}
