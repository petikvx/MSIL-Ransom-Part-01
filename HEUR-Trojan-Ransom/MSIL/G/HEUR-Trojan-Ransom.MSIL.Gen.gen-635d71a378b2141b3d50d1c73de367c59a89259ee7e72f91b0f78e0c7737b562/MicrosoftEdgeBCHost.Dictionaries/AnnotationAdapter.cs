using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceIssuer()
	{
	}
}
