using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StatusState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusState()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceMessage()
	{
	}
}
