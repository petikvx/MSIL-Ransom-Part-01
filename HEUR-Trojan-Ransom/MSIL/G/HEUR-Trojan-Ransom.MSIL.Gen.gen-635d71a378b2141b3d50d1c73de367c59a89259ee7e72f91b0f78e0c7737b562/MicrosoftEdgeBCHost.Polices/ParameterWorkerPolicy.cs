using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParameterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceRepository()
	{
	}
}
