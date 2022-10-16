using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegistryValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInitializer()
	{
	}
}
