using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralTag()
	{
	}
}
