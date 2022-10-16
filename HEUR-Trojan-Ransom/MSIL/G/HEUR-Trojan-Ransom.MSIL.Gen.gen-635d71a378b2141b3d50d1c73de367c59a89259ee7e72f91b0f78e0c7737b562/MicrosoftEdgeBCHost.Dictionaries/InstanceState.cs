using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InstanceState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceState()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceMessage()
	{
	}
}
