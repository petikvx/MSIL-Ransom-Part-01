using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CheckPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckPrinter()
	{
	}
}
