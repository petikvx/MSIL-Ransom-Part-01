using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FacadeRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CallBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallBase()
	{
	}
}
