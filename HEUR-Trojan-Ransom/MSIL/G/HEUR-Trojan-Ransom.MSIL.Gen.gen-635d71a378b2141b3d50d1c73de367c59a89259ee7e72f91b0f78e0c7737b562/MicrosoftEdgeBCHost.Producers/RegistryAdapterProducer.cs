using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegistryAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralMapper()
	{
	}
}
