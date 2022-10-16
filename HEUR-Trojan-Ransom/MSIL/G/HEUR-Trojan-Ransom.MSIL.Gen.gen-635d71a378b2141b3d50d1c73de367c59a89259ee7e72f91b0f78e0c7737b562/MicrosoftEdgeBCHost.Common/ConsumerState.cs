using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConsumerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerState()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceDispatcher()
	{
	}
}
