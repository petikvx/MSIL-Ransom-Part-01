using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClientFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SelectStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectStruct()
	{
	}
}
