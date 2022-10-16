using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdapterWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralClient()
	{
	}
}
