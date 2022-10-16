using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FieldValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		NewProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewProduct()
	{
	}
}
