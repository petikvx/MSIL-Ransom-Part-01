using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProcessValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceProccesor()
	{
	}
}
