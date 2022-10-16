using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DicRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateRule()
	{
	}
}
