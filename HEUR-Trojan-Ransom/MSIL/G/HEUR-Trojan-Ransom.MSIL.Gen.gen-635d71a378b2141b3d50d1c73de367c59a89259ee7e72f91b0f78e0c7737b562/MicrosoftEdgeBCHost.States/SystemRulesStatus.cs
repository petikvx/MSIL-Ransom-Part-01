using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SystemRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceSetter()
	{
	}
}
