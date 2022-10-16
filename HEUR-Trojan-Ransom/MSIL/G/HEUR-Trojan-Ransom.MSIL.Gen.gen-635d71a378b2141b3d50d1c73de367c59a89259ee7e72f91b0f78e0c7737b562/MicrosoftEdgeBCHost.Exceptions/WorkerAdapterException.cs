using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WorkerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceComparator()
	{
	}
}
