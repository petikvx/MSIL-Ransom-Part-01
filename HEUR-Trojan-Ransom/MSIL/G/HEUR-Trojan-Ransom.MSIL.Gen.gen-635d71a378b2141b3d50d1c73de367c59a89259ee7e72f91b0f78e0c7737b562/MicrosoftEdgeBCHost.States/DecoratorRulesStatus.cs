using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DecoratorRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceModel()
	{
	}
}
