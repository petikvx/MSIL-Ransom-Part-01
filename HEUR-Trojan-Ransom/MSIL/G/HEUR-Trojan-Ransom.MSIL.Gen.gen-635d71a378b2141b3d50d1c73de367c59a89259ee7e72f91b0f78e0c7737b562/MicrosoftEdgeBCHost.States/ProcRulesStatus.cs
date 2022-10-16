using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceTemplate()
	{
	}
}
