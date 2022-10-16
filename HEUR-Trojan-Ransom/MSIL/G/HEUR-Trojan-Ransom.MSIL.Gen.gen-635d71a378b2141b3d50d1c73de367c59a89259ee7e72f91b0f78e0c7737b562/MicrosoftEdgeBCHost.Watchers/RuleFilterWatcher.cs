using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RuleFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInvocation()
	{
	}
}
