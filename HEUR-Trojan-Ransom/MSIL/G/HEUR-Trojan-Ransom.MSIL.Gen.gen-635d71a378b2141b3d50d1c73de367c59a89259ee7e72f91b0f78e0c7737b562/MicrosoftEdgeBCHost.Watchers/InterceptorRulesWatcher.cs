using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterceptorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RestartSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartSetter()
	{
	}
}
