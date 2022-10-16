using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ThreadRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetSetter()
	{
	}
}
