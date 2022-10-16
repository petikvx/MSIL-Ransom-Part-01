using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProductFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceImporter()
	{
	}
}
