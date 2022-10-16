using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InitializerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceComparator()
	{
	}
}
