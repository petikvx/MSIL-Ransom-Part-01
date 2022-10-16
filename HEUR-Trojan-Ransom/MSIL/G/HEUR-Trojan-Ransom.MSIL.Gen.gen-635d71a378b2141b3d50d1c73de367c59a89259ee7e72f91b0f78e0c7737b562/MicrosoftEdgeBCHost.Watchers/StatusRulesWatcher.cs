using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StatusRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateCode()
	{
	}
}
