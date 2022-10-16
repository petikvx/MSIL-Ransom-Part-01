using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigFilter()
	{
		WriterPropertyProducer.ResolveStub();
		PopConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopConfig()
	{
	}
}
