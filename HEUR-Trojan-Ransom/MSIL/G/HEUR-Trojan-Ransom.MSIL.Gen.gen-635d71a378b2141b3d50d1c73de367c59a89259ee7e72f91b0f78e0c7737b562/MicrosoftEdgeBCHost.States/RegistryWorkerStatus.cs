using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegistryWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralAdvisor()
	{
	}
}
