using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ObjectFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadComposer()
	{
	}
}
