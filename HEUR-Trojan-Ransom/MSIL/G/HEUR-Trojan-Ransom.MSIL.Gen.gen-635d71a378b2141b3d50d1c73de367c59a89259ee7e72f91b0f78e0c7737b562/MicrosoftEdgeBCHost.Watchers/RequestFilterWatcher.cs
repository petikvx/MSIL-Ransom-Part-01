using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RequestFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeSingleton()
	{
	}
}
