using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TokenExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenExpression()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralParser()
	{
	}
}
