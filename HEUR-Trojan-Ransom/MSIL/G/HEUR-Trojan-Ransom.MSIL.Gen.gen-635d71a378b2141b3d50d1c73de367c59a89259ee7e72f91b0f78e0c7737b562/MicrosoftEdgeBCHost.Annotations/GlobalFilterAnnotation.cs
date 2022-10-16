using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GlobalFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceObject()
	{
	}
}
