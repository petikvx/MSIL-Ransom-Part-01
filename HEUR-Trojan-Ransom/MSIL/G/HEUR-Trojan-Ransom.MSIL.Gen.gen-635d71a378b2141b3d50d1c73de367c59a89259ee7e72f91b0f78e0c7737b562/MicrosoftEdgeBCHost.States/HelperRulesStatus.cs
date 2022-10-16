using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalcBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcBase()
	{
	}
}
