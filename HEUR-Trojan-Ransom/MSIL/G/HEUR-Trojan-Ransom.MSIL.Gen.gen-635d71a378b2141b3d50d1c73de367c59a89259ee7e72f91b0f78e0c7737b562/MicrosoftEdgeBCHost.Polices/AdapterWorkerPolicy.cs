using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdapterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceMap()
	{
	}
}
