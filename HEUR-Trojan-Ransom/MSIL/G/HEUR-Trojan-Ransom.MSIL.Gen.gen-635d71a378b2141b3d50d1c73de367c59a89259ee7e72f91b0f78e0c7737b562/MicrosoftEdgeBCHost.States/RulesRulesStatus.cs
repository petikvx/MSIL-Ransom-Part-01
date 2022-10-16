using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RulesRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PushFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushFilter()
	{
	}
}
