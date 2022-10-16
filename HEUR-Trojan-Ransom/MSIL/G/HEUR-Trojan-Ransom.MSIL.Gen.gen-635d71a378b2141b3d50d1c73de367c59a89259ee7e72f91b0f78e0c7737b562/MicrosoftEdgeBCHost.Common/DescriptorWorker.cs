using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DescriptorWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeList()
	{
	}
}
