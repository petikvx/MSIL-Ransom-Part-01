using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SystemWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralReponse()
	{
	}
}
