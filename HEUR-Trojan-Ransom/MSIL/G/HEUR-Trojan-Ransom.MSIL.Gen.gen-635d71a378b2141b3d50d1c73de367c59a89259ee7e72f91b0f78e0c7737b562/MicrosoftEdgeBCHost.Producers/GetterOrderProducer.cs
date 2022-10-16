using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GetterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralFactory()
	{
	}
}
