using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefineCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineCreator()
	{
	}
}
