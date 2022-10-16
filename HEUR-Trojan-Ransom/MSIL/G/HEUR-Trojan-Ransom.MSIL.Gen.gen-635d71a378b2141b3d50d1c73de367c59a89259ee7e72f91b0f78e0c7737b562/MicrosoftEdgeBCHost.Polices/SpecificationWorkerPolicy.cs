using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SpecificationWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceFacade()
	{
	}
}
