using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DescriptorValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceParameter()
	{
	}
}
