using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcessRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceProperty()
	{
	}
}
