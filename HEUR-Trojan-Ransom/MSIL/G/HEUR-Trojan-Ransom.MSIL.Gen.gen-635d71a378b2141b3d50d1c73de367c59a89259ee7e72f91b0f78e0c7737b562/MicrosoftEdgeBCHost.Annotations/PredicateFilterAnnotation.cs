using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PredicateFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceProduct()
	{
	}
}
