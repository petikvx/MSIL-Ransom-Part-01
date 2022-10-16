using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AnnotationProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationProperty()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceBridge()
	{
	}
}
