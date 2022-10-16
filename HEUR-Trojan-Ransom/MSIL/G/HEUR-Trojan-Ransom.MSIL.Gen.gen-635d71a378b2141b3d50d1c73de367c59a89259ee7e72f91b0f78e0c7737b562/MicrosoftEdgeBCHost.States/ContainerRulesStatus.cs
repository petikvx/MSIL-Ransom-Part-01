using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContainerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceMessage()
	{
	}
}
