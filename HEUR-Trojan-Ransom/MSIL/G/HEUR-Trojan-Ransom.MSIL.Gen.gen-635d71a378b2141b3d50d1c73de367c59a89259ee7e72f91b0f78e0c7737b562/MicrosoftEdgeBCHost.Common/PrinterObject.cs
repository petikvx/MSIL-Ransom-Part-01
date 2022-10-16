using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrinterObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterObject()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralComparator()
	{
	}
}
