using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BroadcasterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralParser()
	{
	}
}
