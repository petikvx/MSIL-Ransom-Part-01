using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DescriptorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorClass()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceRegistry()
	{
	}
}
