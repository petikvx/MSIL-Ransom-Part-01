using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class OrderWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralFacade()
	{
	}
}
