using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ResolverState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverState()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceContext()
	{
	}
}
