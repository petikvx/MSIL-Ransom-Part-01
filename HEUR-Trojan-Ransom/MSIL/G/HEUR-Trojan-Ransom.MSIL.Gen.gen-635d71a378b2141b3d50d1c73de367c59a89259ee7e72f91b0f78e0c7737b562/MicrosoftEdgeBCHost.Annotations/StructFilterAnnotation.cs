using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StructFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceIndexer()
	{
	}
}
