using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WorkerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceMap()
	{
	}
}
