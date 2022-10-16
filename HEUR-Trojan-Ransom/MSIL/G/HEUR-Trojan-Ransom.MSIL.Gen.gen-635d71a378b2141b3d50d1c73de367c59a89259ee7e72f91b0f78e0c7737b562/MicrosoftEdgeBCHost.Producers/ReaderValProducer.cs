using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReaderValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FindResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindResolver()
	{
	}
}
