using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WorkerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		SetFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetFilter()
	{
	}
}
