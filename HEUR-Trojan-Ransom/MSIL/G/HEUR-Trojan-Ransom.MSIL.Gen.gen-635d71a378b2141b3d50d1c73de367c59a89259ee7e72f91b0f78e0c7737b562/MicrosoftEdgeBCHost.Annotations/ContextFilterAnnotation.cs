using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContextFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceObject()
	{
	}
}
