using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExpressionWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetThread()
	{
	}
}
