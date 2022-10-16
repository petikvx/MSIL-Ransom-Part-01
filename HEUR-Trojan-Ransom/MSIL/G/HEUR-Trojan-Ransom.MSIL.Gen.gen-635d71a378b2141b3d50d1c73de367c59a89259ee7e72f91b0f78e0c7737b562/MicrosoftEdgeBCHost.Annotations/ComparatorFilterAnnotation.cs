using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComparatorFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceService()
	{
	}
}
