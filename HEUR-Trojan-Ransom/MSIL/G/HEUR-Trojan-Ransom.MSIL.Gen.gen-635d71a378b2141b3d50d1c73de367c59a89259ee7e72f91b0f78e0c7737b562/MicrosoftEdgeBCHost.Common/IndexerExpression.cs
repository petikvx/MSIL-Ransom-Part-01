using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IndexerExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralExporter()
	{
	}
}
