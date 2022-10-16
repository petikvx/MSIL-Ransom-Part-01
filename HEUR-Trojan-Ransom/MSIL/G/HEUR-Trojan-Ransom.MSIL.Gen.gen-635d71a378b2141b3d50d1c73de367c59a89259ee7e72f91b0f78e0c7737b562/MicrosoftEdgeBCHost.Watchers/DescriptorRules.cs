using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DescriptorRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorRules()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateOrder()
	{
	}
}
