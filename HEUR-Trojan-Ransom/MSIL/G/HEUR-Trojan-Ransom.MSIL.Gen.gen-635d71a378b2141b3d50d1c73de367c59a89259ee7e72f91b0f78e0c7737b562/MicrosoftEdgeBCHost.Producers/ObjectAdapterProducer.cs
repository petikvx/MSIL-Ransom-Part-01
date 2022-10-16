using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObjectAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralDecorator()
	{
	}
}
