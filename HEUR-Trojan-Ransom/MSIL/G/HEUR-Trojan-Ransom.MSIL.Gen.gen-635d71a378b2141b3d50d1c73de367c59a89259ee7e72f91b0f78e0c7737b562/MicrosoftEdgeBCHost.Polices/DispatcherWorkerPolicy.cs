using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DispatcherWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfacePage()
	{
	}
}
