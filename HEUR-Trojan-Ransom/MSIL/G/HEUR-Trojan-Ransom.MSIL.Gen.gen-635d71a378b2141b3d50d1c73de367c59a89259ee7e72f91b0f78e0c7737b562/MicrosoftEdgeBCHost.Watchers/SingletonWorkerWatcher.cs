using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralManager()
	{
	}
}
