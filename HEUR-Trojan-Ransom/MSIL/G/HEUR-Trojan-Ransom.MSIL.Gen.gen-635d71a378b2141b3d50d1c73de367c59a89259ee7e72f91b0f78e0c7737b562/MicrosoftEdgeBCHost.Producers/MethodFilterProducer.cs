using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MethodFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyMapping()
	{
	}
}
