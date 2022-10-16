using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapperValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceMock()
	{
	}
}
