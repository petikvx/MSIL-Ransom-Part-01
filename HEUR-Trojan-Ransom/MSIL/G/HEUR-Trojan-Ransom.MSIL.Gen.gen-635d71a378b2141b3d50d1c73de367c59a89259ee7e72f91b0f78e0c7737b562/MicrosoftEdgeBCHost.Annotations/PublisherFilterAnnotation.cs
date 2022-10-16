using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PublisherFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceService()
	{
	}
}
