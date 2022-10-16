using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttributeOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralValue()
	{
	}
}
