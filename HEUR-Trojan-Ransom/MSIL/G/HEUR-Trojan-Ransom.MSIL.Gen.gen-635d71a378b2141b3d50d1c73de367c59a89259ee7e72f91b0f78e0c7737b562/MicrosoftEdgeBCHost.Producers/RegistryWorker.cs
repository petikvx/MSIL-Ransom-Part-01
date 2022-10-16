using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegistryWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInvocation()
	{
	}
}
