using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneConfiguration()
	{
	}
}
