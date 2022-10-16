using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StubWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralStrategy()
	{
	}
}
