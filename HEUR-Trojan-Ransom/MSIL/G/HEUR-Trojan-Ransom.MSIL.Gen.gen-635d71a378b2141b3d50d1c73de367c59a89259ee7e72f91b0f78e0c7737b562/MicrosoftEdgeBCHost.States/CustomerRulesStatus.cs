using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CustomerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceProperty()
	{
	}
}
