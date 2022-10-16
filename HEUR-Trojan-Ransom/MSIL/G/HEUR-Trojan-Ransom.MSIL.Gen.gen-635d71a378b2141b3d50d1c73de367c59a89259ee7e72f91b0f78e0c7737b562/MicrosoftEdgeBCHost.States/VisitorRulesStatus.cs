using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class VisitorRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceMapping()
	{
	}
}
