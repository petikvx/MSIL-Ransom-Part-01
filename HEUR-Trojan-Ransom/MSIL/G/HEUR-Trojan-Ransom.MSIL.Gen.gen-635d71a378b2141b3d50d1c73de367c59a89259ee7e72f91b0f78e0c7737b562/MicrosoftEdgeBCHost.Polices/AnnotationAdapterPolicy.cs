using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralExpression()
	{
	}
}
