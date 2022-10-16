using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProductAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralRecord()
	{
	}
}
