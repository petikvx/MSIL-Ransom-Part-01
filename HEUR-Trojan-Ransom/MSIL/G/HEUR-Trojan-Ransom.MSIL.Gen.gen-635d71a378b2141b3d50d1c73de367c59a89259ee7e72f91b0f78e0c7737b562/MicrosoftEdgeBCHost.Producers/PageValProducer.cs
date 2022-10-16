using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PageValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineWrapper()
	{
	}
}
