using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AnnotationFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CalcComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcComparator()
	{
	}
}
