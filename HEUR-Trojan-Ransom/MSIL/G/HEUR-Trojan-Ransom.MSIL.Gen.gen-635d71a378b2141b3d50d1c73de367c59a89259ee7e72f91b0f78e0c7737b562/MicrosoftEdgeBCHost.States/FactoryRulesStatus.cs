using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactoryRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceFactory()
	{
	}
}
