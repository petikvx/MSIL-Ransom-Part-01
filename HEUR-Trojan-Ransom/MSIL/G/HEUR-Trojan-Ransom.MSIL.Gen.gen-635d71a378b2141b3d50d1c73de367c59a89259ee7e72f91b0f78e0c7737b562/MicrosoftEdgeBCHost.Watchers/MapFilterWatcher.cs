using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterpreter()
	{
	}
}
