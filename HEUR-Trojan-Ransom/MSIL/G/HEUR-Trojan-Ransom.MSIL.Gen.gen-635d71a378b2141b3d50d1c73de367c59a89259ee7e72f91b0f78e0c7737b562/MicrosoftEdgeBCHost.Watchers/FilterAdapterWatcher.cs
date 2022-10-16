using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FilterAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralSerializer()
	{
	}
}
