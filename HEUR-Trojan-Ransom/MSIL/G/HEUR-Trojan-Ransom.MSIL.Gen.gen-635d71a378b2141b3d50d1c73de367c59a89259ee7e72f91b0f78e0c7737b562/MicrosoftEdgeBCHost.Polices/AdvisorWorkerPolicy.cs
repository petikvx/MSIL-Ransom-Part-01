using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdvisorWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceProducer()
	{
	}
}
