using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RoleWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceTask()
	{
	}
}
