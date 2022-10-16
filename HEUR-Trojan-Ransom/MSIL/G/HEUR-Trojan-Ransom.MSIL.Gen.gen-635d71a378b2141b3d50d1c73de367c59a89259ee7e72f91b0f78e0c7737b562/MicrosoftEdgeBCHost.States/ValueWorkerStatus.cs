using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValueWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralSystem()
	{
	}
}
