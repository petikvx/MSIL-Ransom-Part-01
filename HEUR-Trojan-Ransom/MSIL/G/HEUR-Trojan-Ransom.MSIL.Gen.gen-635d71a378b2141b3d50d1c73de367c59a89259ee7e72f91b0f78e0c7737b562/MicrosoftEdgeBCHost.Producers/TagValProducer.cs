using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TagValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		NewStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewStrategy()
	{
	}
}
