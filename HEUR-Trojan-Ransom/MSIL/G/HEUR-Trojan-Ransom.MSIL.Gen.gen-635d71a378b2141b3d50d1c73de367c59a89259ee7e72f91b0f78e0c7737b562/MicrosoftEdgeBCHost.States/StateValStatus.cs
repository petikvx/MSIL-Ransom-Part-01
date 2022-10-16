using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StateValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralEvent()
	{
	}
}
