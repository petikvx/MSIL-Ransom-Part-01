using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CustomerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceEvent()
	{
	}
}
