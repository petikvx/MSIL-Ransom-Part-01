using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigurationValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortStrategy()
	{
	}
}
