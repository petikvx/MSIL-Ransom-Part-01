using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DescriptorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FillCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillCollection()
	{
	}
}
