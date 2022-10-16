using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapState()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceMessage()
	{
	}
}
