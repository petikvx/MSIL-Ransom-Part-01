using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TokenFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		NewProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewProducer()
	{
	}
}
