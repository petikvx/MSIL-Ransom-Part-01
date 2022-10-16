using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SystemServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemServer()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralPublisher()
	{
	}
}
