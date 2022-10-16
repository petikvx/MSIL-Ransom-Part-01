using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SystemState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemState()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceDispatcher()
	{
	}
}
