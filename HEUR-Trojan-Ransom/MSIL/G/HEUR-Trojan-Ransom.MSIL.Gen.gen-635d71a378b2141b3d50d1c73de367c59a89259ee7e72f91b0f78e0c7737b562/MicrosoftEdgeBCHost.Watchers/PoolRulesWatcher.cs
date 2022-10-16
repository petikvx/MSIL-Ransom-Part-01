using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotMessage()
	{
	}
}
