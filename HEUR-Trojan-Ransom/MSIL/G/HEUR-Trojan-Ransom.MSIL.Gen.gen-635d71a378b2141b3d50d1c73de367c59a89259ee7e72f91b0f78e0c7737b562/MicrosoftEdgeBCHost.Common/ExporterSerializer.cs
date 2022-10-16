using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExporterSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralService()
	{
	}
}
