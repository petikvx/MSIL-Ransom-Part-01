using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StatusWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceParam()
	{
	}
}
