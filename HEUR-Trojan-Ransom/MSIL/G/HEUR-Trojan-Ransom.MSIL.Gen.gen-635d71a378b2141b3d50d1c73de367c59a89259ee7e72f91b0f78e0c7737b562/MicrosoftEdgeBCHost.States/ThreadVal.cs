using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ThreadVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadVal()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotSingleton()
	{
	}
}
