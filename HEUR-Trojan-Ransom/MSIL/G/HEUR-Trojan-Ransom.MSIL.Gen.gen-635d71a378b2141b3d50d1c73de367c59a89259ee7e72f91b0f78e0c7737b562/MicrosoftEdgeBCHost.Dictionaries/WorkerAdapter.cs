using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WorkerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceMethod()
	{
	}
}
