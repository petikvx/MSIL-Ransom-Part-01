using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InitializerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotException()
	{
	}
}
