using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AuthenticationWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		OrderConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderConfiguration()
	{
	}
}
