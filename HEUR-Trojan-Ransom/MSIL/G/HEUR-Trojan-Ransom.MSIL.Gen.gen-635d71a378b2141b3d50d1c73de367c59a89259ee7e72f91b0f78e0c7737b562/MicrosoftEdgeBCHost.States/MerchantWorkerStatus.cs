using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MerchantWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralProcess()
	{
	}
}
