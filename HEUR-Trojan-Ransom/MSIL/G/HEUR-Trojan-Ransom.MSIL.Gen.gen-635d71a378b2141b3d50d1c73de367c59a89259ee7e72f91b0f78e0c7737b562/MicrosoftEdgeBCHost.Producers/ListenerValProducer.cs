using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListenerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetPrinter()
	{
	}
}
