using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PropertyRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PatchObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchObserver()
	{
	}
}
