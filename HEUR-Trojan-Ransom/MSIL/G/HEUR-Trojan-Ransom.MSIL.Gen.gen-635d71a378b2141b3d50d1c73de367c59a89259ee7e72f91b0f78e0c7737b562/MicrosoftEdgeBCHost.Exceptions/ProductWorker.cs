using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProductWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CreateCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateCallback()
	{
	}
}
