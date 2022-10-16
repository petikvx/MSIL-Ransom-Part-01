using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceIdentifier()
	{
	}
}
