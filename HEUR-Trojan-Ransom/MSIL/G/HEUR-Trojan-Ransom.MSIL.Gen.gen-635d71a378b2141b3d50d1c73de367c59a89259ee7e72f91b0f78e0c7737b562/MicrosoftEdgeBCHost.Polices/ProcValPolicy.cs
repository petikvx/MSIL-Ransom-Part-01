using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProcValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceService()
	{
	}
}
