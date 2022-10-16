using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionHelper()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralSystem()
	{
	}
}
