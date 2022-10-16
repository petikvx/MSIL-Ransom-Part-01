using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StateOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceThread()
	{
	}
}
