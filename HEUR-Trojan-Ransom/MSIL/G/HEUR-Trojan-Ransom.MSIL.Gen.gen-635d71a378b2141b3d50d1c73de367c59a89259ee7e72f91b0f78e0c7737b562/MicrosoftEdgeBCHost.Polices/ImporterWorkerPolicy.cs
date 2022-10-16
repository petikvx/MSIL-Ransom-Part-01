using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceStrategy()
	{
	}
}
