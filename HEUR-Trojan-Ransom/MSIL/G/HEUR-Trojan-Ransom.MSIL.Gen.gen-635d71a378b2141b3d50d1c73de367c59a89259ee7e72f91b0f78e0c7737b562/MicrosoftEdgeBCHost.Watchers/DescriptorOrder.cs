using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DescriptorOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RestartRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartRule()
	{
	}
}
