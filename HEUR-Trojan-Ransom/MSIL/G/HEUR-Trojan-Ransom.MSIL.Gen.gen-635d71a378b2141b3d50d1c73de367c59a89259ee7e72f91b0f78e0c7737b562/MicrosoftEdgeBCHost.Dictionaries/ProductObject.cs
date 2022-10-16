using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProductObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductObject()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralSchema()
	{
	}
}
