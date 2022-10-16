using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdvisorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralTask()
	{
	}
}
