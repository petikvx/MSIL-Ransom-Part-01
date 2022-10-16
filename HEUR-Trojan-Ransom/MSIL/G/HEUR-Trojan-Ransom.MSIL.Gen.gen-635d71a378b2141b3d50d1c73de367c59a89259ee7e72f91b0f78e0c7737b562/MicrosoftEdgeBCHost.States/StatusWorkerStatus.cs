using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StatusWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralCallback()
	{
	}
}
