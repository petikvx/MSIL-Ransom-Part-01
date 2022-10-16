using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AttributeWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceSystem()
	{
	}
}
