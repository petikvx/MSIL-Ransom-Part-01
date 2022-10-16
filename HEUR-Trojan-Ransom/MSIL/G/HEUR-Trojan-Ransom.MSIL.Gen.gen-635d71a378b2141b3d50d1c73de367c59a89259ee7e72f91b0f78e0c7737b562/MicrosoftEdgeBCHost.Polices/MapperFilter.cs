using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapperFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperFilter()
	{
		WriterPropertyProducer.ResolveStub();
		SelectWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectWatcher()
	{
	}
}
