using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WorkerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceProduct()
	{
	}
}
