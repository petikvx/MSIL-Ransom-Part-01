using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateTemplate()
	{
	}
}
