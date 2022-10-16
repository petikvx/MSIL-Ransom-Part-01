using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MethodWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceRepository()
	{
	}
}
