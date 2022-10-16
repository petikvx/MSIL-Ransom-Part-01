using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TagObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagObject()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralProduct()
	{
	}
}
