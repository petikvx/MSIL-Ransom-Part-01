using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RulesFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceComposer()
	{
	}
}
