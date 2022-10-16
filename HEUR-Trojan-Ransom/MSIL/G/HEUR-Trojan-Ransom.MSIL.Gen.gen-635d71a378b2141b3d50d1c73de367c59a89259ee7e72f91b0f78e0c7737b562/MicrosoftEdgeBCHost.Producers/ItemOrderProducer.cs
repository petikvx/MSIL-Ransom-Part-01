using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ItemOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralInstance()
	{
	}
}
