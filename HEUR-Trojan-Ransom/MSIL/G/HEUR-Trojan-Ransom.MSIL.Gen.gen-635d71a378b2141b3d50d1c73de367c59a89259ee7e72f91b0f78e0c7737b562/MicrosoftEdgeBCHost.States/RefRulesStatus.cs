using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RefRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceListener()
	{
	}
}
