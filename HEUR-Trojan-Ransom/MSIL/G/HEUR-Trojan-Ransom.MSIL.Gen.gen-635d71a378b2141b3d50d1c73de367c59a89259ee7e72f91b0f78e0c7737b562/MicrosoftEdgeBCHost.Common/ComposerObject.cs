using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComposerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerObject()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralProduct()
	{
	}
}
