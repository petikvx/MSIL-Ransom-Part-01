using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ErrorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchReg()
	{
	}
}
