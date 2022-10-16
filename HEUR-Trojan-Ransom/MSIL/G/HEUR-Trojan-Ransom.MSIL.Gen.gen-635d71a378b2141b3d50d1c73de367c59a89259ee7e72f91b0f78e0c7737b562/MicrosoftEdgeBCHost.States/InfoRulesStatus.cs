using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InfoRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceState()
	{
	}
}
