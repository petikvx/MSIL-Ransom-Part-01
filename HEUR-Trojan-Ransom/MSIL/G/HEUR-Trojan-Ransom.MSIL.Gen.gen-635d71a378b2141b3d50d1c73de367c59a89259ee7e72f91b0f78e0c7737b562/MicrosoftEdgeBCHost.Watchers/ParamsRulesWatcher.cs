using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamsRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcMapping()
	{
	}
}
