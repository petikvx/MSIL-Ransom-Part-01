using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ResolverWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceAnnotation()
	{
	}
}
