using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClassFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeParams()
	{
	}
}
