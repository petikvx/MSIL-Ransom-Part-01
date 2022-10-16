using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComparatorExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorExpression()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralMap()
	{
	}
}
