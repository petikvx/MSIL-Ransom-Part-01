using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DescriptorPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceSystem()
	{
	}
}
