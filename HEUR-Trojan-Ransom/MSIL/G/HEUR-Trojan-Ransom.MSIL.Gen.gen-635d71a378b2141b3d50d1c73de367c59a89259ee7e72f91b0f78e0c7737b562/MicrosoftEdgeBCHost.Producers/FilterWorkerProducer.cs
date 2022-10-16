using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FilterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelField()
	{
	}
}
