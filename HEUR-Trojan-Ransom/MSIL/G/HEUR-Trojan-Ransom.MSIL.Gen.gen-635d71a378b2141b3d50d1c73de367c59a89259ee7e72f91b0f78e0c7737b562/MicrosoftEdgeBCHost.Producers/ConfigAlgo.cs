using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralDefinition()
	{
	}
}
