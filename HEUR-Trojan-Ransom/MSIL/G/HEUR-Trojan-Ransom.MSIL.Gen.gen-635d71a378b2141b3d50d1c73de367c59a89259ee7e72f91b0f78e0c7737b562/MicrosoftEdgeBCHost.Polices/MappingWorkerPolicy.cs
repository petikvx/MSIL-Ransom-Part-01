using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MappingWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceSpecification()
	{
	}
}
