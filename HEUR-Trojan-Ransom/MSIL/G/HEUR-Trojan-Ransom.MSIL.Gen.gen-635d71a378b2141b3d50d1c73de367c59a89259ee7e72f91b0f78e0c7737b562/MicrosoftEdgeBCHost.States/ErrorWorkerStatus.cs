using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ErrorWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralSpecification()
	{
	}
}
