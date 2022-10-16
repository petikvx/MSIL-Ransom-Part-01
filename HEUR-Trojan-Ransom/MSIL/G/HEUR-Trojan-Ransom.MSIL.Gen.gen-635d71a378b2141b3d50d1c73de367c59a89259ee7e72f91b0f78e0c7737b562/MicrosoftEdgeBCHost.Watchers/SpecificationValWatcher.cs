using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SpecificationValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceTag()
	{
	}
}
