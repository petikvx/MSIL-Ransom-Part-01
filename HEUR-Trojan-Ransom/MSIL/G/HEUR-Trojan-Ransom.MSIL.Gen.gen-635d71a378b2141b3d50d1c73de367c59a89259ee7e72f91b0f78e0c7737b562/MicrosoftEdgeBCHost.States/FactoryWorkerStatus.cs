using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactoryWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralProcess()
	{
	}
}
