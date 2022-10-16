using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class UtilsRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeObserver()
	{
	}
}
