using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SystemValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyTemplate()
	{
	}
}
