using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapperRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceListener()
	{
	}
}
