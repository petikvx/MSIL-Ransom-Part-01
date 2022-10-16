using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DestroySystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroySystem()
	{
	}
}
