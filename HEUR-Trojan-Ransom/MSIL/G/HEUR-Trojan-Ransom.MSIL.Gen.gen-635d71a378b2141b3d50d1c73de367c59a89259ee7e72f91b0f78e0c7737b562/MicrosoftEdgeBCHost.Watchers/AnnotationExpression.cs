using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AnnotationExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralRef()
	{
	}
}
