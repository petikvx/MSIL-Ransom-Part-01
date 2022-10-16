using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DescriptorFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfacePolicy()
	{
	}
}
