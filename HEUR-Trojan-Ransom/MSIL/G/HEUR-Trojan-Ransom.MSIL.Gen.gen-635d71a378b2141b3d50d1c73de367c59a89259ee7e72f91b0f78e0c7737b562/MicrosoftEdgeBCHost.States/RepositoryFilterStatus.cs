using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RepositoryFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceObserver()
	{
	}
}
