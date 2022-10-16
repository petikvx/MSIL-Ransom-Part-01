using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralReader()
	{
	}
}
