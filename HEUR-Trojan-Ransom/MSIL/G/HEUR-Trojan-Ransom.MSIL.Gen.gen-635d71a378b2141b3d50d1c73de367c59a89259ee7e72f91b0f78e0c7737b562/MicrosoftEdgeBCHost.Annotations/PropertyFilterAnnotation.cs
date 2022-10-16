using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PropertyFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceIssuer()
	{
	}
}
