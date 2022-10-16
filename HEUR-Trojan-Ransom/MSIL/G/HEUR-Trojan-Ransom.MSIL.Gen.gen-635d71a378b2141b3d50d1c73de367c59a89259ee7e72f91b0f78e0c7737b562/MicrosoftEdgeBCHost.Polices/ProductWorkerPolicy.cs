using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProductWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceDefinition()
	{
	}
}
