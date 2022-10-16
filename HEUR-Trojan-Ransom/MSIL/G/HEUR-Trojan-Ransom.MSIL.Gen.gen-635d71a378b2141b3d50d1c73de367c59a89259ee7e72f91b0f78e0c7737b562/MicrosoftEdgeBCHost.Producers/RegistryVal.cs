using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegistryVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryVal()
	{
		WriterPropertyProducer.ResolveStub();
		ResetContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetContainer()
	{
	}
}
