using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcessRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CloneException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneException()
	{
	}
}
