using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralItem()
	{
	}
}
