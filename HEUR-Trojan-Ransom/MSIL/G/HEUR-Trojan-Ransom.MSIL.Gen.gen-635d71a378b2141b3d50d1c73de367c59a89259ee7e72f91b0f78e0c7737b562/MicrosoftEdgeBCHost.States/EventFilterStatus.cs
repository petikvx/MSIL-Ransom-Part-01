using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class EventFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceCallback()
	{
	}
}
