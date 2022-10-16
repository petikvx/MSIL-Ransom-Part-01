using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CountRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountRules()
	{
	}
}
