using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdvisorRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceMessage()
	{
	}
}
