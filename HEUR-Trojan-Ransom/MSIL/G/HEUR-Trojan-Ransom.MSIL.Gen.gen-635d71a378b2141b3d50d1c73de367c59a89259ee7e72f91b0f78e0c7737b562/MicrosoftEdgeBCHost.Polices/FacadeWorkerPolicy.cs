using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FacadeWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceTests()
	{
	}
}
