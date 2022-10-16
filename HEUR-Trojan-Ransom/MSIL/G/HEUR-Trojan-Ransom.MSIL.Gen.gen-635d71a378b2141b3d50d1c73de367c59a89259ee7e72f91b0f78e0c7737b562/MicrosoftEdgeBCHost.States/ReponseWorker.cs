using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReponseWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseWorker()
	{
		WriterPropertyProducer.ResolveStub();
		VisitProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitProcess()
	{
	}
}
